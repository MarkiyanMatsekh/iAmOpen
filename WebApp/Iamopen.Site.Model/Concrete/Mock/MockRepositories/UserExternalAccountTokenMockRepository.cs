using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class UserExternalAccountTokenMockRepository : GenericMockRepositoryWithIntegerID<UserExternalAccountToken>
    {
        protected override List<UserExternalAccountToken> _collection { get { return MockData.UserExternalAccountTokens; } }
    }
}
