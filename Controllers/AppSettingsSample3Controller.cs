using Microsoft.AspNetCore.Mvc;

namespace AppSettingsSample.Controllers;

[ApiController]
[Route("[controller]")]
public class AppSettingsSample3Controller : ControllerBase
{
    private readonly ILogger<AppSettingsSample3Controller> _logger;
    private readonly IConfiguration _configuration;

    public AppSettingsSample3Controller(ILogger<AppSettingsSample3Controller> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var appName = _configuration["AppSettings:AppName"];
        var appVersion = _configuration["AppSettings:AppVersion"];
        var appDescription = _configuration["AppSettings:AppDescription"];

        _logger.LogInformation($"AppName: {appName}");

        return Ok(new
        {
            AppName = appName,
            AppVersion = appVersion,
            AppDescription = appDescription
        });
    }
}
