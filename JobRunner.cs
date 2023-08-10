using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace ConsoleJobRunner;

public class JobRunner : BackgroundService
{
    private readonly IHostApplicationLifetime hostLifetime;
    private readonly IOptions<AppOptions> options;

    public JobRunner(
        IHostApplicationLifetime hostLifetime,
        IOptions<AppOptions> options)
    {
        this.hostLifetime = hostLifetime;
        this.options = options;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("JobRunner enter");
        Console.WriteLine($"Running [{options.Value.JobName}]");
        Console.WriteLine("Job run complete.");

        hostLifetime.StopApplication();
        
        Console.WriteLine("JobRunner exit.");

        
    }
}
