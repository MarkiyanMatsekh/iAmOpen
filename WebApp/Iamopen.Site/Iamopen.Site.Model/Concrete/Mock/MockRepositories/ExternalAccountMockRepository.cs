using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class ExternalAccountMockRepository : GenericMockRepositoryWithIntegerID<ExternalAccount>
    {
        protected override List<ExternalAccount> _collection { get { return MockData.ExternalAccounts; } }
    }
}
