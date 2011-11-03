using System;
using System.Collections.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class StateMockRepository : GenericMockRepository<State>
    {
        protected override List<State> _collection { get { return MockData.States; } }

        protected override void UpdateEntityIDBeforeAddingToCollection(State entity) { }
    }
}
