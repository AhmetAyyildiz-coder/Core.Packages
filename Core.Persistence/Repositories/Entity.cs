namespace Core.Persistence.Repositories;

public class Entity<TId> : IEntityTimestamps
{
    public Entity(TId id)
    {
        Id = id;
    }
    public Entity()
    {
        Id = default;
    }
    public TId Id { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}