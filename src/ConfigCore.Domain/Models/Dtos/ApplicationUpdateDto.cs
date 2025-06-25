namespace ConfigCore.Domain.Models.Dtos;

public sealed class ApplicationUpdateDto
{
    public Ulid Id { get; init; }
    public string Name { get; init; } = null!;
}
