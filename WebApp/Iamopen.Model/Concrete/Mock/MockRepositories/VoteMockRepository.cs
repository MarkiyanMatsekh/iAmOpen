using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.Models;
using System.Linq.Expressions;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    class VoteMockRepository : IAmOpen.Model.Abstractions.IGenericRepository<Vote>
    {
        private static List<Vote> _collection { get { return MockData.Votes; } }

        public virtual IEnumerable<Vote> Get(
            Expression<Func<Vote, bool>> filter = null,
            Func<IQueryable<Vote>, IOrderedQueryable<Vote>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<Vote> query = _collection.AsQueryable();

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

        public virtual Vote GetByID(object id)
        {
            return _collection.Find(delegate(Vote v) { return v.VoteID == Convert.ToInt32(id); });
        }

        public virtual void Insert(Vote entity)
        {
            if (!_collection.Contains(entity))
            {
                var lastID = _collection[_collection.Count - 1].VoteID;
                entity.VoteID = ++lastID;
                _collection.Add(entity);
            }
        }

        public virtual void Delete(object id)
        {
            Vote vote = GetByID(id);
            if (_collection.Contains(vote))
                _collection.Remove(vote);
        }

        public virtual void Delete(Vote entityToDelete)
        {
            if (_collection.Contains(entityToDelete))
            {
                _collection.Remove(entityToDelete);
            }
        }

        public virtual void Update(Vote entityToUpdate)
        {
            int index = _collection.FindIndex(p => p.VoteID == entityToUpdate.VoteID);
            if (index >= 0)
                _collection[index] = entityToUpdate;
        }
    }
}
