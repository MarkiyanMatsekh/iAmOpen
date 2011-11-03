using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.Models;
using System.Linq.Expressions;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class InstitutionMockRepository : IAmOpen.Model.Abstractions.IGenericRepository<Institution>
    {
        private static List<Institution> _collection {get { return MockData.Institutions; }}

        public virtual IEnumerable<Institution> Get(
            Expression<Func<Institution, bool>> filter = null,
            Func<IQueryable<Institution>, IOrderedQueryable<Institution>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<Institution> query = _collection.AsQueryable();

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

        public virtual Institution GetByID(object id)
        {
            return _collection.Find(delegate(Institution i) { return i.InstitutionID == Convert.ToInt32(id); });
        }

        public virtual void Insert(Institution entity)
        {
            if (!_collection.Contains(entity))
            {
                var lastID = _collection[_collection.Count - 1].InstitutionID;
                entity.InstitutionID = ++lastID;
                _collection.Add(entity);
            }
        }

        public virtual void Delete(object id)
        {
            Institution institution = GetByID(id);
            if (_collection.Contains(institution))
                _collection.Remove(institution);
        }

        public virtual void Delete(Institution entityToDelete)
        {
            if (_collection.Contains(entityToDelete))
            {
                _collection.Remove(entityToDelete);
            }
        }

        public virtual void Update(Institution entityToUpdate)
        {
            int index = _collection.FindIndex(p => p.InstitutionID == entityToUpdate.InstitutionID);
            if (index >= 0)
                _collection[index] = entityToUpdate;
        }
    }
}
