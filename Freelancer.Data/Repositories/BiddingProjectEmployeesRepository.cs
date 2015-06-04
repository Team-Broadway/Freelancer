namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;
    public class BiddingProjectEmployeesRepository : GenericRepository<BiddingProjectEmployee>
    {
        public BiddingProjectEmployeesRepository(ApplicationDbContext context)
            :base(context)
        {
        }
    }
}
