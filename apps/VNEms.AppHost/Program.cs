

using VNEms.AppHost;

var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres(VNEmsNames.Postgres).WithPgWeb();
var rabbitMq = builder.AddRabbitMQ(VNEmsNames.RabbitMq).WithManagementPlugin();
var redis = builder.AddRedis(VNEmsNames.Redis).WithRedisCommander();
var seq = builder.AddSeq(VNEmsNames.Seq);

var adminDb = postgres.AddDatabase(VNEmsNames.VNEmsAdminDb);
var resourceDb = postgres.AddDatabase(VNEmsNames.VNEmsResourceDb);

builder.AddProject<Projects.VNEms_Gateway>(VNEmsNames.Gateway);

builder.Build().Run();
