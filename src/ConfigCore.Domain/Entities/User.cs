namespace ConfigCore.Domain.Entities;

[Index(nameof(Email), IsUnique = true)]
public sealed class User : IEntity
{
    [Key]
    public Ulid Id { get; set; }
    
    [Required]
    public DateTime CreatedAtUtc { get; set; }
    
    [Required]
    public DateTime ModifiedAtUtc { get; set; }
    
    [Required]
    [StringLength(50)]
    public string FirstName { get; init; } = string.Empty;
    
    [Required]
    [StringLength(50)]
    public string LastName { get; init; } = string.Empty;
    
    [Required]
    [StringLength(100)]
    [EmailAddress]
    public string Email { get; init; } = string.Empty;
    
    [Required]
    [StringLength(500)]
    public string PasswordHash { get; set; } = string.Empty;
    
    [Required]
    [StringLength(100)]
    public string PasswordSalt { get; set; } = string.Empty;
    
    public DateTime? LastLoginUtc { get; set; }
    
    public bool IsActive { get; set; } = true;
}