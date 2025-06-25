using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ConfigCore.Domain.Entities.Interfaces;

namespace ConfigCore.Domain.Entities.EnumEntities;

public sealed class EnvironmentType : IEnumEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    [MaxLength(100)] 
    [Required] 
    public string Name { get; set; } = null!;
    
    private EnvironmentType(EnvironmentTypeEnum environmentTypeEnum)
    {
        if (!Enum.IsDefined(environmentTypeEnum))
        {
            throw new ArgumentException($"Invalid environment value: {environmentTypeEnum}");
        }
        
        Id = (int)environmentTypeEnum;
        Name = environmentTypeEnum.ToString();
    }
    
    public EnvironmentType() { } // Constructor for EF Core - Please do not remove it.
    
    public static implicit operator EnvironmentType(EnvironmentTypeEnum environmentTypeEnum)
    {
        return new EnvironmentType(environmentTypeEnum);
    }

    public static implicit operator EnvironmentTypeEnum(EnvironmentType environmentType)
    {
        return (EnvironmentTypeEnum)environmentType.Id;
    }
}