namespace ConfigCore.Domain.Entities;

[Index(nameof(ApplicationId), nameof(Name), IsUnique = true)]
public sealed class ServiceAccount : IEntity
{
    [Key]
    public Ulid Id { get; set; }
    
    [Required]
    public DateTime CreatedAtUtc { get; set; }
    
    [Required]
    public DateTime ModifiedAtUtc { get; set; }
    
    [Required]
    [StringLength(50)]
    public string Name { get; init; } = string.Empty;
    
    [StringLength(500)]
    public string? Description { get; init; }
    
    [Required]
    [ForeignKey(nameof(Application))]
    public Ulid ApplicationId { get; init; }
    public Application Application { get; set; } = null!;
    
    [Required]
    [ForeignKey(nameof(User))]
    public Ulid CreatedByUserId { get; init; }
    public User CreatedByUser { get; set; } = null!;
    
    public bool IsActive { get; set; } = true;
}