using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.Models;
using System.Linq.Expressions;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class UserMockRepository : GenericMockRepository<User>
    {
        protected override List<User> _collection
        {
            get { return MockData.Users; }
        }

        public override User GetByID(object id)
        {
            return _collection.Find(u => u.UserID == Convert.ToInt32(id));
        }

        public override void Update(User entityToUpdate)
        {
            int index = _collection.FindIndex(p => p.UserID == entityToUpdate.UserID);
            if (index >= 0)
                _collection[index] = entityToUpdate;
        }

        protected override void UpdateEntityIDBeforeAddingToCollection(User entity)
        {
            var lastID = _collection[_collection.Count - 1].UserID;
            entity.UserID = ++lastID;
        }
    }
}
