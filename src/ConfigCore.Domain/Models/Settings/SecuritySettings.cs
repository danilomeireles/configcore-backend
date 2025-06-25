namespace ConfigCore.Domain.Models.Settings;

public class SecuritySettings
{
    public EncryptionSettings Encryption { get; set; } = new();
    public JwtSettings Jwt { get; set; } = new();
}