namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;

    public class MessagesRepository : GenericRepository<Message>
    {
        public MessagesRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
