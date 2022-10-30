namespace AppSettingsSample;

public class AppSettings
{
    public AppInformation AppInformation { get; set; } = new AppInformation();
    public string AllowedHosts { get; set; } = "*";
}

public class AppInformation
{
    public string AppName { get; set; } = string.Empty;
    public string AppVersion { get; set; } = string.Empty;
    public string AppDescription { get; set; } = string.Empty;
}