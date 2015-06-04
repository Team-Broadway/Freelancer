namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;
    public class QuestionsRepository : GenericRepository<Question>
    {
        public QuestionsRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}