var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireAppCrud_ApiService>("apiservice");

builder.AddProject<Projects.AspireAppCrud_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
