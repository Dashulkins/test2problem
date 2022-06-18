using Microsoft.EntityFrameworkCore;

namespace tests22297.Models
{
    public class ContextMy : DbContext
    {
        public ContextMy()
        {
        }

        public ContextMy(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s22297;Integrated Security=True; TrustServerCertificate=true");
        }
        public DbSet<FireFighter> FireFighters { get; set; }    
        public DbSet<FireTruck> FireTrucks { get; set; }   
        public DbSet<Action> Actions { get; set; }
        public DbSet<FireFighterAction> FireFightersActions { get; set; }
        public DbSet<FireTruckAction> FireTruckActions { get; set; } 
    }
}
