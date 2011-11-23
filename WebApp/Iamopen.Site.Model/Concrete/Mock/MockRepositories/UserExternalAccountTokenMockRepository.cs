using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class UserExternalAccountTokenMockRepository : GenericMockRepositoryWithIntegerID<UserExternalAccountToken>
    {
        protected override List<UserExternalAccountToken> _collection { get { return MockData.UserExternalAccountTokens; } }
    }
}
