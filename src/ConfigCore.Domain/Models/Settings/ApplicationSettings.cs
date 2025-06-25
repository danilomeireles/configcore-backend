namespace ConfigCore.Domain.Models.Settings;

public class ApplicationSettings
{
    public string Version { get; set; } = string.Empty;
    public string AllowedHosts { get; set; } = "*";
}