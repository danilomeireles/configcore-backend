using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ConfigCore.Domain.Entities.EnumEntities;
using ConfigCore.Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConfigCore.Domain.Entities;

[Index(nameof(TokenHash), nameof(EnvironmentTypeId), IsUnique = true)]
public sealed class ServiceAccountToken  : IEntity
{
    [Key]
    public Ulid Id { get; set; }
    
    [Required]
    public DateTime CreatedAtUtc { get; set; }
    
    [Required]
    public DateTime ModifiedAtUtc { get; set; }
    
    [Required]
    [StringLength(500)]
    public string TokenHash { get; init; } = string.Empty;
    
    [Required]
    [ForeignKey(nameof(ServiceAccount))]
    public Ulid ServiceAccountId { get; init; }
    public ServiceAccount ServiceAccount { get; set; } = null!;
    
    [Required]
    [ForeignKey(nameof(EnvironmentType))]
    public int EnvironmentTypeId { get; init; }
    public EnvironmentType EnvironmentType { get; init; } = null!;
    
    [Required]
    public DateTime ExpiresAtUtc { get; init; }
    
    public bool IsRevoked { get; set; }
    
    [ForeignKey(nameof(RevokedByUser))]
    public Ulid? RevokedByUserId { get; set; }
    
    public User? RevokedByUser { get; set; }
    
    public DateTime? RevokedAtUtc { get; set; }
}