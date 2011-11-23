using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using IAmOpen.Model.Abstractions;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Concrete.Mock.Generic
{
    public abstract class GenericMockRepository<TEntity,TID> : IGenericRepository<TEntity> 
        where TEntity : EntityWithID<TID> 
        where TID : IEquatable<TID>
    {
        protected abstract List<TEntity> _collection { get; }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _collection.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            /*foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }*/

            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return _collection.Find(c => c.ID.Equals(id));
        }

        public virtual void Insert(TEntity entity)
        {
            if (!_collection.Contains(entity))
            {
                UpdateEntityIDBeforeAddingToCollection(entity);
                _collection.Add(entity);
            }
        }

        public virtual void Delete(object id)
        {
            TEntity entity = GetByID(id);
            Delete(entity);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (_collection.Contains(entityToDelete))
            {
                _collection.Remove(entityToDelete);
            }
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            int index = _collection.FindIndex(p => p.Equals(entityToUpdate));
            if (index >= 0)
                _collection[index] = entityToUpdate;
        }

        protected abstract void UpdateEntityIDBeforeAddingToCollection(TEntity entity);
    }
}
