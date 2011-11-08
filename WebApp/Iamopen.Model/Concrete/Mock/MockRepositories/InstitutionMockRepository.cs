using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class InstitutionMockRepository : GenericMockRepositoryWithIntegerID<Institution>
    {
        protected override List<Institution> _collection { get { return MockData.Institutions; } }
    }
}
