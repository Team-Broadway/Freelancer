namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;

    public class ExamsRepository : GenericRepository<Exam>
    {
        public ExamsRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
