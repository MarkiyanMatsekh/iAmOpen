using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class ChainMockRepository : IAmOpen.Model.Abstractions.IGenericRepository<IAmOpen.Model.Models.Chain>
    {
        public virtual IEnumerable<IAmOpen.Model.Models.Chain> Get(
            Expression<Func<IAmOpen.Model.Models.Chain, bool>> filter = null,
            Func<IQueryable<IAmOpen.Model.Models.Chain>, IOrderedQueryable<IAmOpen.Model.Models.Chain>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<IAmOpen.Model.Models.Chain> query = MockData.Chains.AsQueryable();

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

        public virtual IAmOpen.Model.Models.Chain GetByID(object id)
        {
            return MockData.Chains.Find(delegate(IAmOpen.Model.Models.Chain c) { return c.ChainID == Convert.ToInt32(id); });
        }

        public virtual void Insert(IAmOpen.Model.Models.Chain entity)
        {
            if (!MockData.Chains.Contains(entity))
                MockData.Chains.Add(entity);
        }

        public virtual void Delete(object id)
        {
            IAmOpen.Model.Models.Chain chain = GetByID(id);
            if (MockData.Chains.Contains(chain))
                MockData.Chains.Remove(chain);
        }

        public virtual void Delete(IAmOpen.Model.Models.Chain entityToDelete)
        {
            if (MockData.Chains.Contains(entityToDelete))
            {
                MockData.Chains.Remove(entityToDelete);
            }
        }

        public virtual void Update(IAmOpen.Model.Models.Chain entityToUpdate)
        {
            int index = MockData.Chains.FindIndex(p => p.ChainID == entityToUpdate.ChainID);
            if (index >= 0)
                MockData.Chains[index] = entityToUpdate;
        }
    }
}
