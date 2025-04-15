var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache")
 .WithRedisCommander();


var api = builder.AddProject<Projects.Api>("api")
    .WithReference(cache)
    .WaitFor(cache);

var web = builder.AddProject<Projects.MyWeatherHub>("web")
    .WithReference(api)
    .WaitFor(api)
    .WithExternalHttpEndpoints();



builder.Build().Run();
