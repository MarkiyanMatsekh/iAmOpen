using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.Models;
using System.Linq.Expressions;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class UserMockRepository : IAmOpen.Model.Abstractions.IGenericRepository<User>
    {
        private static List<User> _collection { get { return MockData.Users; } }

        public virtual IEnumerable<User> Get(
            Expression<Func<User, bool>> filter = null,
            Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<User> query = _collection.AsQueryable();

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

        public virtual User GetByID(object id)
        {
            return _collection.Find(delegate(User u) { return u.UserID == Convert.ToInt32(id); });
        }

        public virtual void Insert(User entity)
        {
            if (!_collection.Contains(entity))
            {
                var lastID = _collection[_collection.Count - 1].UserID;
                entity.UserID = ++lastID;
                _collection.Add(entity);
            }
        }

        public virtual void Delete(object id)
        {
            User user = GetByID(id);
            if (_collection.Contains(user))
                _collection.Remove(user);
        }

        public virtual void Delete(User entityToDelete)
        {
            if (_collection.Contains(entityToDelete))
            {
                _collection.Remove(entityToDelete);
            }
        }

        public virtual void Update(User entityToUpdate)
        {
            int index = _collection.FindIndex(p => p.UserID == entityToUpdate.UserID);
            if (index >= 0)
                _collection[index] = entityToUpdate;
        }
    }
}
