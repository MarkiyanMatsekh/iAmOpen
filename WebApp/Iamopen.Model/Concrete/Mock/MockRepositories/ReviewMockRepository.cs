using System.Collections.Generic;
using IAmOpen.Model.Concrete.Mock.Generic;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock.MockRepositories
{
    public class ReviewMockRepository: GenericMockRepositoryWithIntegerID<Review>
    {
        protected override List<Review> _collection { get { return MockData.Reviews; } }
    }
}
