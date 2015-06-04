namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;
    public class ReviewsRepository : GenericRepository<Review>
    {
        public ReviewsRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}