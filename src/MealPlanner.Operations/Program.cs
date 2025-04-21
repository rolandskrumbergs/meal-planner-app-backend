using MealPlanner.Operations;
using Microsoft.Extensions.DependencyInjection;

using var host = OperationsHost.Create(CommonOptions.ParseFromCommandLineArgs(args));

await host.StartAsync();

using var scope = host.Services.CreateScope();

//var result = await Parser.Default
//    .ParseArguments(args)
//    .MapResult();

await host.StopAsync();

//return result;
