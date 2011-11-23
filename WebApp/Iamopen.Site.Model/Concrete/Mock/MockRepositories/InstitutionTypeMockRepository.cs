using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class InstitutionTypeMockRepository : GenericMockRepositoryWithIntegerID<InstitutionType>
    {
        protected override List<InstitutionType> _collection { get { return MockData.InstitutionTypes; } }
    }
}
