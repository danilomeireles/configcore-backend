namespace ConfigCore.Domain.Models.Dtos;

public class ServiceAccountCreateDto
{
    public string Name { get; set; } = null!;
 
    public string? Description { get; set; }
    
    public Ulid ApplicationId { get; set; }
}