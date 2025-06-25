namespace ConfigCore.Domain.Models.Dtos;

public class ServiceAccountTokenCreateResponseDto
{
    public Ulid Id { get; set; }
    public string Token { get; set; } = null!;
    public DateTime ExpiresAtUtc { get; set; }
    public int EnvironmentTypeId { get; set; }
}