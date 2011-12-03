using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class UserMockRepository : GenericMockRepositoryWithIntegerID<User>
    {
        protected override List<User> _collection { get { return MockData.Users; } }
    }
}
