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
        protected override List<User> _collection { get { return MockData.Users; } }
    }
}
