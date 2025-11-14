using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzUserRepository : BeeBuzzGenericGenericRepository<User>
    {
        public BeeBuzzUserRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<User>> logger) : base(db, logger)
        {
        }
    }
}
