using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class InstitutionMockRepository : GenericMockRepositoryWithIntegerID<Institution>
    {
        protected override List<Institution> _collection { get { return MockData.Institutions; } }
    }
}
