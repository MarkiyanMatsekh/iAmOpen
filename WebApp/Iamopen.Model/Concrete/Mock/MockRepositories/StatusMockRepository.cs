using System;
using System.Collections.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class StatusMockRepository : GenericMockRepository<Status>
    {
        protected override List<Status> _collection
        {
            get { return MockData.Statuses; }
        }

        protected override void UpdateEntityIDBeforeAddingToCollection(Status entity) { }

        public override Status GetByID(object id)
        {
            return MockData.Statuses.Find(s => s.StatusID == Convert.ToInt32(id));
        }

        public override void Update(Status entityToUpdate)
        {
            int index = MockData.Statuses.FindIndex(p => p.StatusID == entityToUpdate.StatusID);
            if (index >= 0)
                MockData.Statuses[index] = entityToUpdate;
        }
    }
}
