using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace ConsoleJobRunner;

public class JobRunner : BackgroundService
{
    private readonly IHostApplicationLifetime hostLifetime;
    private readonly IConfiguration config;

    public JobRunner(
        IHostApplicationLifetime hostLifetime,
        IConfiguration config)
    {
        this.hostLifetime = hostLifetime;
        this.config = config;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("JobRunner enter");
        Console.WriteLine($"Running {config["jobname"]}");
        Console.WriteLine("Job run complete.");

        hostLifetime.StopApplication();
        
        Console.WriteLine("JobRunner exit.");

        
    }
}
