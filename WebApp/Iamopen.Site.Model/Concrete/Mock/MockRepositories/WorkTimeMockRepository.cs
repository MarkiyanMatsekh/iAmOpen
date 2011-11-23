using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class WorkTimeMockRepository : GenericMockRepositoryWithIntegerID<WorkTime>
    {
        protected override List<WorkTime> _collection { get { return MockData.WorkTimes; } }
    }
}
