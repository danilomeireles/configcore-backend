namespace ConfigCore.Domain.Models.Settings;

public class EncryptionSettings
{
    public string KeyDerivationSalt { get; set; } = string.Empty;
    public string MasterKey { get; set; } = string.Empty;
}