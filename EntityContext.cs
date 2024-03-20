using Microsoft.EntityFrameworkCore;
using PatrolPal.Model;
namespace PatrolPal
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
