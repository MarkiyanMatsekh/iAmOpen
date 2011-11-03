using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using IAmOpen.Model.Abstractions;

namespace IAmOpen.Model.Concrete.Mock
{
    public abstract class GenericMockRepository<T> : IGenericRepository<T> where T : class
    {
        protected abstract List<T> _collection { get; }

        protected abstract void UpdateEntityID(T entity);

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

        public abstract T GetByID(object id);

        public virtual void Insert(T entity)
        {
            if (!_collection.Contains(entity))
            {
                UpdateEntityID(entity);
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

        public abstract void Update(T entityToUpdate);
    }
}
