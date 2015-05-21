namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;
    public class ProjectsRepository : GenericRepository<Project>
    {
        public ProjectsRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}