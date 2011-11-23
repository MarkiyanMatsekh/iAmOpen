using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class VoteMockRepository : GenericMockRepositoryWithIntegerID<Vote>
    {
        protected override List<Vote> _collection { get { return MockData.Votes; } }
    }
}
