using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class VoteMockRepository : GenericMockRepositoryWithIntegerID<Vote>
    {
        protected override List<Vote> _collection { get { return MockData.Votes; } }
    }
}
