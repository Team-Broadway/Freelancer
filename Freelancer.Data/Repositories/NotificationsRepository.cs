namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;
    public class NotificationsRepository : GenericRepository<Notification>
    {
        public NotificationsRepository(ApplicationDbContext context)
            :base(context)
        {
        }
    }
}
