// See https://aka.ms/new-console-template for more information

using ConsoleJobRunner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

Console.WriteLine("Building host ...");

var host = Host.CreateDefaultBuilder(args)
    .ConfigureHostConfiguration(configuration =>
    {
        configuration.AddCommandLine(args);
    })
    .ConfigureServices((HostBuilderContext hostContext, IServiceCollection services) =>
    {
        services.AddHostedService<JobRunner>();
        // ...
    })
    .Build();

Console.WriteLine("Host running ...");

await host.RunAsync();

Console.WriteLine("Host stopped.");
