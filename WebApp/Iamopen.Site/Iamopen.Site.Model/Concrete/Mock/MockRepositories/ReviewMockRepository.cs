using System.Collections.Generic;
using IAmOpen.Site.Model.Concrete.Mock.Generic;
using IAmOpen.Site.Model.Models;

namespace IAmOpen.Site.Model.Concrete.Mock.MockRepositories
{
    public class ReviewMockRepository: GenericMockRepositoryWithIntegerID<Review>
    {
        protected override List<Review> _collection { get { return MockData.Reviews; } }
    }
}
