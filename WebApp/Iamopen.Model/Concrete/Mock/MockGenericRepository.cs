using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using IAmOpen.Model.Abstractions;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock
{
    public class MockINstitutionRepository: IGenericRepository<Institution>
    {
        public IEnumerable<Institution> Get(Expression<Func<Institution, bool>> filter = null, Func<IQueryable<Institution>, IOrderedQueryable<Institution>> orderBy = null, string includeProperties = "")
        {
            return new List<Institution>()
                       {
                           new  Institution {ChainID= 1}
                       };
        }

        public Institution GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Institution entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Institution entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Update(Institution entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
