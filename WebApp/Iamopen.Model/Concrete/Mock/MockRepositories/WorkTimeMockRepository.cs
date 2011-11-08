using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class WorkTimeMockRepository : GenericMockRepositoryWithIntegerID<WorkTime>
    {
        protected override List<WorkTime> _collection { get { return MockData.WorkTimes; } }
    }
}
