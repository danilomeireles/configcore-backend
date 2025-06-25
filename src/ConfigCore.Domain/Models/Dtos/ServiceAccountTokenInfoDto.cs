namespace ConfigCore.Domain.Models.Dtos;

public class ServiceAccountTokenInfoDto
{
    public Ulid Id { get; set; }
    public DateTime ExpiresAtUtc { get; set; }
    public int EnvironmentTypeId { get; set; }
    public string EnvironmentTypeName { get; set; } = null!;
    public bool IsRevoked { get; set; }
    public DateTime CreatedAtUtc { get; set; }
}