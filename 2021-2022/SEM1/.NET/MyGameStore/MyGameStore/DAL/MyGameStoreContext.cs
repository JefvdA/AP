using Microsoft.EntityFrameworkCore;
using MyGameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.DAL
{
    public class MyGameStoreContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
