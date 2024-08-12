namespace Movies.Core.Entities.Base;

public class EntityBase<TId>: IEntityBase<IId>
{
    public virtual TId { get; protected set; }
}
