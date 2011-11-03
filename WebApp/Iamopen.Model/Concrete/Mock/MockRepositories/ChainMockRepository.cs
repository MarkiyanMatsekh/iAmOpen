using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class ChainMockRepository : GenericMockRepository<Chain>
    {
        protected override List<Chain> _collection
        {
            get { return MockData.Chains; }
        }

        protected override void UpdateEntityIDBeforeAddingToCollection(Chain entity) { }

        public override Chain GetByID(object id)
        {
            return MockData.Chains.Find(c => c.ChainID == Convert.ToInt32(id));
        }

        public override void Update(Chain entityToUpdate)
        {
            int index = MockData.Chains.FindIndex(p => p.ChainID == entityToUpdate.ChainID);
            if (index >= 0)
                MockData.Chains[index] = entityToUpdate;
        }
    }
}
