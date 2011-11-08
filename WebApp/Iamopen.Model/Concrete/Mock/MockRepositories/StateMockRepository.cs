using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.MockRepositories.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class StateMockRepository : GenericMockRepositoryWithIntegerID<State>
    {
        protected override List<State> _collection { get { return MockData.States; } }
    }
}
