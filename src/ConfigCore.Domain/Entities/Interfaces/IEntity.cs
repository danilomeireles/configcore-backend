namespace ConfigCore.Domain.Entities.Interfaces;

public interface IEntity
{
    Ulid Id { get; set; }
    DateTime CreatedAtUtc { get; set; }
    DateTime ModifiedAtUtc { get; set; }
}
