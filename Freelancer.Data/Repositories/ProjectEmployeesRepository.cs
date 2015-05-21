namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;
    public class ProjectEmployeesRepository : GenericRepository<ProjectEmployee>
    {
        public ProjectEmployeesRepository(ApplicationDbContext context)
            :base(context)
        {

        }
    }
}
