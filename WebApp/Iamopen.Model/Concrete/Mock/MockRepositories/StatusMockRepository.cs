using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class StatusMockRepository : IAmOpen.Model.Abstractions.IGenericRepository<IAmOpen.Model.Models.Status>
    {
        public virtual IEnumerable<IAmOpen.Model.Models.Status> Get(
            Expression<Func<IAmOpen.Model.Models.Status, bool>> filter = null,
            Func<IQueryable<IAmOpen.Model.Models.Status>, IOrderedQueryable<IAmOpen.Model.Models.Status>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<IAmOpen.Model.Models.Status> query = MockData.Statuses.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            /*foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }*/

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual IAmOpen.Model.Models.Status GetByID(object id)
        {
            return MockData.Statuses.Find(delegate(IAmOpen.Model.Models.Status s) { return s.StatusID == Convert.ToInt32(id); });
        }

        public virtual void Insert(IAmOpen.Model.Models.Status entity)
        {
            if (!MockData.Statuses.Contains(entity))
                MockData.Statuses.Add(entity);
        }

        public virtual void Delete(object id)
        {
            IAmOpen.Model.Models.Status status = GetByID(id);
            if (MockData.Statuses.Contains(status))
                MockData.Statuses.Remove(status);
        }

        public virtual void Delete(IAmOpen.Model.Models.Status entityToDelete)
        {
            if (MockData.Statuses.Contains(entityToDelete))
            {
                MockData.Statuses.Remove(entityToDelete);
            }
        }

        public virtual void Update(IAmOpen.Model.Models.Status entityToUpdate)
        {
            int index = MockData.Statuses.FindIndex(p => p.StatusID == entityToUpdate.StatusID);
            if (index >= 0)
                MockData.Statuses[index] = entityToUpdate;
        }
    }
}
