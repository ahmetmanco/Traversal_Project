using Microsoft.EntityFrameworkCore;

namespace SignalRAPI.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SERVER=DESKTOP-I6RBC1D;database=TraversalSignalRAPI;integrated security=true;Trusted_Connection=True; MultipleActiveResultSets=true; Encrypt=False;");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}