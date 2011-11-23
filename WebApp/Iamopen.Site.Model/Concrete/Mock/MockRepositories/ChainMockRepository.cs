using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class ChainMockRepository : GenericMockRepositoryWithIntegerID<Chain>
    {
        protected override List<Chain> _collection { get { return MockData.Chains; } }
    }
}
