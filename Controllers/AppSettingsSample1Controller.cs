using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AppSettingsSample.Controllers;

[ApiController]
[Route("[controller]")]
public class AppSettingsSample1Controller : ControllerBase
{
    private readonly ILogger<AppSettingsSample2Controller> _logger;
    private readonly IOptions<AppSettings> _appSettings;

    public AppSettingsSample1Controller(ILogger<AppSettingsSample2Controller> logger, IOptions<AppSettings> appSettings)
    {
        _logger = logger;
        _appSettings = appSettings;
    }

    [HttpGet("GetAppSettings")]
    public IActionResult Get()
    {
        var appName = _appSettings.Value.AppInformation.AppName;
        var appVersion = _appSettings.Value.AppInformation.AppVersion;
        var appDescription = _appSettings.Value.AppInformation.AppDescription;

        _logger.LogInformation($"AppName: {appName}");

        return Ok(_appSettings.Value);
    }
}
