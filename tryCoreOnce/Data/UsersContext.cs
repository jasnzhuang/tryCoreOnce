using Microsoft.EntityFrameworkCore;

namespace tryCoreOnce.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext (DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
