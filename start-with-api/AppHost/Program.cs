using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache")
    .WithRedisCommander();

var api = builder.AddProject<Api>("api")
    .WithReference(cache);

var web = builder.AddProject<MyWeatherHub>("myweatherhub")
    .WithReference(api)
    .WithExternalHttpEndpoints();

builder.Build().Run();
