using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ConfigCore.Domain.Entities.EnumEntities;
using ConfigCore.Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConfigCore.Domain.Entities;

[Index(nameof(ApplicationId), nameof(EnvironmentTypeId), nameof(Name), IsUnique = true)]
public sealed class FeatureFlag : IEntity
{
    [Key]
    public Ulid Id { get; set; }
    
    [Required]
    public DateTime CreatedAtUtc { get; set; }
    
    [Required]
    public DateTime ModifiedAtUtc { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    [RegularExpression("^[a-zA-Z][a-zA-Z0-9_-]*$")]
    public string Name { get; set; } = string.Empty;
    
    [StringLength(500)]
    public string? Description { get; set; }
    
    [Required]
    public bool IsEnabled { get; set; }
    
    [ForeignKey(nameof(Application))]
    public Ulid? ApplicationId { get; set; }
    public Application? Application { get; set; } = null!;
    
    [Required]
    [ForeignKey(nameof(EnvironmentType))]
    public int EnvironmentTypeId { get; set; }
    public EnvironmentType EnvironmentType { get; set; } = null!;
}