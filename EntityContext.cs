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
        public DbSet<MapStats> MapStats { get; set; }
        public DbSet<CameraLocation> CameraLocation { get; set; }
        public DbSet<FirDetails> FirDetails { get; set; }
        public DbSet<MarketPlace> MarketPlaces { get; set; }
        public DbSet<PoliceLocation> PoliceLocations { get; set; }
        public DbSet<PoliceStations> PoliceStations { get; set; }
        public DbSet<Raw> Raw { get; set; }
        public DbSet<Records> Records { get; set; }
        public DbSet<User> User { get; set; }
    }
}
