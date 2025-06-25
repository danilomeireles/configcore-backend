namespace ConfigCore.Domain.Entities;

[Index(nameof(ApplicationId), nameof(EnvironmentTypeId), nameof(Key), IsUnique = true)]
public sealed class Secret : IEntity
{
    [Key]
    public Ulid Id { get; set; }
    
    [Required]
    public DateTime CreatedAtUtc { get; set; }
    
    [Required]
    public DateTime ModifiedAtUtc { get; set; }
    
    public DateTime? ExpiresAtUtc { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    [RegularExpression("^[a-zA-Z][a-zA-Z0-9_-]*$")]
    public string Key { get; set; } = string.Empty;

    [Required] 
    public byte[] EncryptedValue { get; set; } = [];
    
    [ForeignKey(nameof(Application))]
    public Ulid? ApplicationId { get; set; }
    public Application? Application { get; set; }
    
    [Required]
    [ForeignKey(nameof(EnvironmentType))]
    public int EnvironmentTypeId { get; set; }
    public EnvironmentType EnvironmentType { get; set; } = null!;
}