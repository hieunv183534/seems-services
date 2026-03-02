var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.VNEms_Gateway>("vnems-gateway");

builder.Build().Run();
