var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AuthCenter_WebHost>("authcenter-webhost");

builder.AddProject<Projects.AuthCenter_Sample_WebHost>("authcenter-sample-webhost");

builder.Build().Run();
