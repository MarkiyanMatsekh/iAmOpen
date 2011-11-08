using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class InstitutionTypeMockRepository : GenericMockRepositoryWithIntegerID<InstitutionType>
    {
        protected override List<InstitutionType> _collection { get { return MockData.InstitutionTypes; } }
    }
}
