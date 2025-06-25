namespace ConfigCore.Domain.Entities;

[Index(nameof(Name), IsUnique = true)]
public sealed class Application : IEntity
{
    [Key]
    public Ulid Id { get; set; }
    
    [Required]
    public DateTime CreatedAtUtc { get; set; }
    
    [Required]
    public DateTime ModifiedAtUtc { get; set; }
    
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
}