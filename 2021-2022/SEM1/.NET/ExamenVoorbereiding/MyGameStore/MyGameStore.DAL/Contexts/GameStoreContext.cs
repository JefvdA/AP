using Microsoft.EntityFrameworkCore;
using MyGameStore.DAL.Configurations;
using MyGameStore.DAL.Extensions;
using MyGameStore.DAL.Model;

namespace MyGameStore.DAL.Contexts
{
    public class GameStoreContext : DbContext
    {
        public DbSet<Person> People { get; set; }
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
