using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class RoleMockRepository : GenericMockRepositoryWithIntegerID<Role>
    {
        protected override List<Role> _collection { get { return MockData.Roles; } }
    }
}
