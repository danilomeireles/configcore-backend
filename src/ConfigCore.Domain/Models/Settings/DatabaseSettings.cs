namespace ConfigCore.Domain.Models.Settings;

public class DatabaseSettings
{
    public string ConnectionString { get; set; } = string.Empty;
    public string Schema { get; set; } = string.Empty;
}