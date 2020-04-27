using Microsoft.EntityFrameworkCore;
using RestaurantLibrary.Models;
namespace RestaurantLibrary
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Executant> Executants { get; set; }
        public DbSet<Export> Exports { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Task> TaskModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=pdb.uzservice.in.ua;Database=restorant;Username=postgres;Password=Aa1234567890");
        }
    }
}
