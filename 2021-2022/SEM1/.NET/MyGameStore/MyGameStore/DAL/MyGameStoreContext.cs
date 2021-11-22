using Microsoft.EntityFrameworkCore;
using MyGameStore.Configuration;
using MyGameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MyGameStore.DAL
{
    public class MyGameStoreContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Store> Stores { get; set; }

        public MyGameStoreContext(DbContextOptions<MyGameStoreContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            modelBuilder.Entity<Person>().HasData(
                new Person { ID = -1, FirstName = "Jef", LastName = "van der Avoirt", Email = "jef.v.d.a@live.be", Gender = 0 }
            );
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
