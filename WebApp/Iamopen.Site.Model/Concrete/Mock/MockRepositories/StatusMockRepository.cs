using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class StatusMockRepository : GenericMockRepositoryWithIntegerID<Status>
    {
        protected override List<Status> _collection { get { return MockData.Statuses; } }
    }
}
