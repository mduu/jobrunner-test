// See https://aka.ms/new-console-template for more information

using ConsoleJobRunner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

Console.WriteLine("Building host ...");

var hostBuilder = Host.CreateApplicationBuilder(args);
hostBuilder.Services.AddHostedService<JobRunner>();
hostBuilder.Services.AddOptions<AppOptions>();
hostBuilder.Services.AddSingleton<IValidateOptions<AppOptions>, AppOptionsValidator>();
var host = hostBuilder.Build();

Console.WriteLine("Host running ...");

await host.RunAsync();

Console.WriteLine("Host stopped.");
