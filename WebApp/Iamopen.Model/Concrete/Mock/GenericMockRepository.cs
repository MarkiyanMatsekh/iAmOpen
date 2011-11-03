using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using IAmOpen.Model.Abstractions;
using IAmOpen.Model.Models;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Concrete.Mock
{
    public abstract class GenericMockRepository<T> : IGenericRepository<T> where T : EquatableEntity
    {
        protected abstract List<T> _collection { get; }

        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = _collection.AsQueryable();

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

        public virtual T GetByID(object id)
        {
            return _collection.Find(c => c.EntityID.Equals(id));
        }

        public virtual void Insert(T entity)
        {
            if (!_collection.Contains(entity))
            {
                UpdateEntityIDBeforeAddingToCollection(entity);
                _collection.Add(entity);
            }
        }

        public virtual void Delete(object id)
        {
            T entity = GetByID(id);
            Delete(entity);
        }

        public virtual void Delete(T entityToDelete)
        {
            if (_collection.Contains(entityToDelete))
            {
                _collection.Remove(entityToDelete);
            }
        }

        public virtual void Update(T entityToUpdate)
        {
            int index = _collection.FindIndex(p => p.EntityID.Equals(entityToUpdate.EntityID));
            if (index >= 0)
                _collection[index] = entityToUpdate;
        }
        // current version works only for integers
        //todo MM: consider transition to generics to avoid such uncertainties
        protected virtual void UpdateEntityIDBeforeAddingToCollection(T entity)
        {
            var lastID = (int)_collection[_collection.Count - 1].EntityID;
            entity.EntityID = ++lastID;
        }

    }
}
