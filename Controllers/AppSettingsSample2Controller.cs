using Microsoft.AspNetCore.Mvc;

namespace AppSettingsSample.Controllers;

[ApiController]
[Route("[controller]")]
public class AppSettingsSample2Controller : ControllerBase
{
    private readonly ILogger<AppSettingsSample2Controller> _logger;
    private readonly IConfiguration _configuration;

    public AppSettingsSample2Controller(ILogger<AppSettingsSample2Controller> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var appSettings = _configuration.Get<AppSettings>();

        _logger.LogInformation($"AppName: {appSettings.AppInformation.AppName}");

        return Ok(appSettings);
    }
}