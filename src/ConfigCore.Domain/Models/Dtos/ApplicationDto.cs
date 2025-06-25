namespace ConfigCore.Domain.Models.Dtos;

public sealed class ApplicationDto
{
    public Ulid Id { get; init; }
    public string Name { get; init; } = null!;
    public DateTime CreatedAtUtc { get; init; }
    public DateTime? ModifiedAtUtc { get; init; }
}