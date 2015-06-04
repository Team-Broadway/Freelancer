namespace Freelancer.Data.Repositories
{
    using Freelancer.Models;
  
    public class UsersRepository : GenericRepository<User>
    {
        public UsersRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
