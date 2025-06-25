namespace ConfigCore.Domain.Models.Dtos;

public class ServiceAccountDto
{
    public Ulid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public Ulid ApplicationId { get; set; }
    public string ApplicationName { get; set; } = null!;
    public string CreatedByUserEmail { get; set; } = null!;
    public bool IsActive { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime ModifiedAtUtc { get; set; }
}