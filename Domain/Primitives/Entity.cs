namespace Domain.Primitives;

public abstract class Entity(Guid id)
{
    public Guid Id { get; protected set; } = id;
    public DateTime CreatedAt { get; protected set; } = DateTime.Now;
}
