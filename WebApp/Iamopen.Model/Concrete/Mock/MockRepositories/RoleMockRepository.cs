using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class RoleMockRepository : GenericMockRepositoryWithIntegerID<Role>
    {
        protected override List<Role> _collection { get { return MockData.Roles; } }
    }
}
