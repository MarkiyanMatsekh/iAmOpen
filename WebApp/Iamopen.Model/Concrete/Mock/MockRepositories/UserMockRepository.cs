using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class UserMockRepository : GenericMockRepositoryWithIntegerID<User>
    {
        protected override List<User> _collection { get { return MockData.Users; } }
    }
}
