namespace ConfigCore.Domain.Models.Dtos;

public class HealthResponseDto
{
    public string Status { get; init; } = string.Empty;
    public string Environment { get; init; } = string.Empty;
    public string Version { get; init; } = string.Empty;
    public Ulid? CurrentUserId { get; init; }
    public DateTime TimestampUtc { get; init; }
    public string Details { get; init; } = string.Empty;
}