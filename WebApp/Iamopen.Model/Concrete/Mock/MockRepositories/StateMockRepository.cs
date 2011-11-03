using System;
using System.Collections.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class StateMockRepository : GenericMockRepository<State>
    {
        protected override List<State> _collection
        {
            get { return MockData.States; }
        }

        protected override void UpdateEntityIDBeforeAddingToCollection(State entity) { }

        public override State GetByID(object id)
        {
            return MockData.States.Find(s => s.StateID == Convert.ToInt32(id));
        }

        public override void Update(State entityToUpdate)
        {
            int index = MockData.States.FindIndex(p => p.StateID == entityToUpdate.StateID);
            if (index >= 0)
                MockData.States[index] = entityToUpdate;
        }
    }
}
