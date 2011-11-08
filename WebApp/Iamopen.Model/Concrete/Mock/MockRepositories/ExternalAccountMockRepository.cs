﻿using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class ExternalAccountMockRepository : GenericMockRepositoryWithIntegerID<ExternalAccount>
    {
        protected override List<ExternalAccount> _collection { get { return MockData.ExternalAccounts; } }
    }
}
