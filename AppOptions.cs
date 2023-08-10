using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace ConsoleJobRunner;

public class AppOptions
{
    [Required]
    public string JobName { get; set; }
}

public class AppOptionsValidator : IValidateOptions<AppOptions>
{
    public ValidateOptionsResult Validate(string? name, AppOptions options) =>
        string.IsNullOrWhiteSpace(options.JobName) 
            ? ValidateOptionsResult.Fail("JobName not specified") 
            : ValidateOptionsResult.Success;
}
