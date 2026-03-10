

using System.Security.Principal;
using VNEms.Shared.Constants;

var builder = DistributedApplication.CreateBuilder(args);



var postgres = builder.AddPostgres(VNEmsNames.Postgres).WithPgWeb();
var rabbitMq = builder.AddRabbitMQ(VNEmsNames.RabbitMq).WithManagementPlugin();
var redis = builder.AddRedis(VNEmsNames.Redis).WithRedisCommander();
var seq = builder.AddSeq(VNEmsNames.Seq);

var adminDb = postgres.AddDatabase(VNEmsNames.VNEmsAdminDb);
var resourceDb = postgres.AddDatabase(VNEmsNames.VNEmsResourceDb);

var adminDbMigrator = builder
            .AddProject<Projects.VNEmsAdmin_DbMigrator>(VNEmsNames.VNEmsAdminDbMigrator)
            .WithReference(adminDb)
            .WithReference(redis)
            .WithReference(seq)
            .WaitFor(redis)
            .WaitFor(postgres);


var adminService = builder.AddProject<Projects.VNEmsAdmin_HttpApi_Host>(VNEmsNames.VNEmsAdminApi)
                    .WithExternalHttpEndpoints()
                    .WithReference(adminDb)
                    .WithReference(rabbitMq)
                    .WithReference(redis)
                    .WithReference(seq)
                    .WaitFor(rabbitMq)
                    .WaitFor(redis)
                    .WaitForCompletion(adminDbMigrator);

var resourceService = builder.AddProject<Projects.VNEmsResource_HttpApi_Host>(VNEmsNames.VNEmsResourceApi)
                    .WithExternalHttpEndpoints()
                    .WithReference(resourceDb)
                    .WithReference(rabbitMq)
                    .WithReference(redis)
                    .WithReference(seq)
                    .WaitFor(rabbitMq)
                    .WaitFor(redis);

var gateway = builder.AddProject<Projects.VNEms_Gateway>(VNEmsNames.Gateway)
                    .WithExternalHttpEndpoints()
                    .WithReference(seq)
                    .WaitFor(adminService)
                    .WaitFor(resourceService);

var authserver = builder.AddProject<Projects.VNEms_AuthServer>(VNEmsNames.AuthServer)
                   .WithExternalHttpEndpoints()
                   .WithReference(adminDb)
                   .WithReference(rabbitMq)
                   .WithReference(redis)
                   .WithReference(seq)
                   .WaitFor(rabbitMq)
                   .WaitFor(redis)
                   .WaitForCompletion(adminDbMigrator);

builder.Build().Run();
