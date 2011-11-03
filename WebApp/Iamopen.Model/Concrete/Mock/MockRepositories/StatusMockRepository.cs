using System;
using System.Collections.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class StatusMockRepository : GenericMockRepository<Status>
    {
        protected override List<Status> _collection { get { return MockData.Statuses; } }

        protected override void UpdateEntityIDBeforeAddingToCollection(Status entity) { }

    }
}
