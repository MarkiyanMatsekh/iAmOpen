using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class ChainMockRepository : GenericMockRepositoryWithIntegerID<Chain>
    {
        protected override List<Chain> _collection { get { return MockData.Chains; } }
    }
}
