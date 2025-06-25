namespace ConfigCore.Domain.Models.Dtos;

public class ServiceAccountTokenCreateDto
{
    public Ulid ServiceAccountId { get; set; }
    
    public int EnvironmentTypeId { get; set; }
    
    public int ExpirationDays { get; set; }
}