using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class StatusMockRepository : GenericMockRepositoryWithIntegerID<Status>
    {
        protected override List<Status> _collection { get { return MockData.Statuses; } }
    }
}
