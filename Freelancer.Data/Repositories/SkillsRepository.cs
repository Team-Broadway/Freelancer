namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;

    public class SkillsRepository : GenericRepository<Skill>
    {
        public SkillsRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
