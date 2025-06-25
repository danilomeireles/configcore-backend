namespace ConfigCore.Domain.Models.Settings;

public class AppSettings
{
    public EnvironmentEnum Environment { get; set; }
    public ApplicationSettings Application { get; set; } = new();
    public DatabaseSettings Database { get; set; } = new();
    public SecuritySettings Security { get; set; } = new();
}