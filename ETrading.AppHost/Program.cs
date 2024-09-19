var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ETradingApi>("etradingapi");

builder.Build().Run();
