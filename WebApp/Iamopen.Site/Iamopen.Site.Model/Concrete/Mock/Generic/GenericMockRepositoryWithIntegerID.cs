using IAmOpen.Site.Model.Models.Base;

namespace IAmOpen.Site.Model.Concrete.Mock.Generic
{
    // todo MM: try to find some better name...
    public abstract class GenericMockRepositoryWithIntegerID<TEntity> : GenericMockRepository<TEntity, int> 
        where TEntity : EntityWithID<int>
    {
        protected override void UpdateEntityIDBeforeAddingToCollection(TEntity entity)
        {
            var lastID = _collection[_collection.Count - 1].ID;
            entity.ID = ++lastID;
        }
    }
}
