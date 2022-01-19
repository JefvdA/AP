using Microsoft.EntityFrameworkCore;
using MyGameStore.Model;

namespace MyGameStore.DAL
{
    public class GameStoreContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Store> Stores { get; set; }

        public GameStoreContext(DbContextOptions<GameStoreContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            modelBuilder.SeedStores();
            modelBuilder.SeedPersons();
        }
    }
}
