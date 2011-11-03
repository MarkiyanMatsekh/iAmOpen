using System;
using System.Collections.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class InstitutionMockRepository : GenericMockRepository<Institution>
    {
        protected override List<Institution> _collection
        {
            get { return MockData.Institutions; }
        }

        public override Institution GetByID(object id)
        {
            return _collection.Find(i => i.InstitutionID == Convert.ToInt32(id));
        }

        public override void Update(Institution entityToUpdate)
        {
            int index = _collection.FindIndex(p => p.InstitutionID == entityToUpdate.InstitutionID);
            if (index >= 0)
                _collection[index] = entityToUpdate;
        }

        protected override void UpdateEntityIDBeforeAddingToCollection(Institution entity)
        {
            var lastID = _collection[_collection.Count - 1].InstitutionID;
            entity.InstitutionID = ++lastID;
        }
    }
}
