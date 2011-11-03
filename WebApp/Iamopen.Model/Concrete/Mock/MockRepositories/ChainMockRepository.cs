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
        protected override List<Chain> _collection { get { return MockData.Chains; } }

        protected override void UpdateEntityIDBeforeAddingToCollection(Chain entity) { }

    }
}
