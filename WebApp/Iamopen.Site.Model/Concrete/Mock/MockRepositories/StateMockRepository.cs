using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class StateMockRepository : GenericMockRepositoryWithIntegerID<State>
    {
        protected override List<State> _collection { get { return MockData.States; } }
    }
}
