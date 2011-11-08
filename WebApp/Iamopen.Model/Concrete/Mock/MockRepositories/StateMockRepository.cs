using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    // TODO: finish this mock repository
    public class StateMockRepository : IAmOpen.Model.Abstractions.IGenericRepository<IAmOpen.Model.Models.State>
    {
        public virtual IEnumerable<IAmOpen.Model.Models.State> Get(
            Expression<Func<IAmOpen.Model.Models.State, bool>> filter = null,
            Func<IQueryable<IAmOpen.Model.Models.State>, IOrderedQueryable<IAmOpen.Model.Models.State>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<IAmOpen.Model.Models.State> query = MockData.States.AsQueryable();

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

        public virtual IAmOpen.Model.Models.State GetByID(object id)
        {
            return MockData.States.Find(delegate(IAmOpen.Model.Models.State s) { return s.StateID == Convert.ToInt32(id); });
        }

        public virtual void Insert(IAmOpen.Model.Models.State entity)
        {
            if (!MockData.States.Contains(entity))
                MockData.States.Add(entity);
        }

        public virtual void Delete(object id)
        {
            var state = GetByID(id);
            if (MockData.States.Contains(state))
                MockData.States.Remove(state);
        }

        public virtual void Delete(Models.State entityToDelete)
        {
            if (MockData.States.Contains(entityToDelete))
            {
                MockData.States.Remove(entityToDelete);
            }
        }

        public virtual void Update(IAmOpen.Model.Models.State entityToUpdate)
        {
            int index = MockData.States.FindIndex(p => p.StateID == entityToUpdate.StateID);
            if (index >= 0)
                MockData.States[index] = entityToUpdate;
        }
    }
}
