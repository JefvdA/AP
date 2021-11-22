using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoRace.Model;

namespace AutoRace.DAL
{
    public class AutoRaceContext : DbContext
    {
        public AutoRaceContext(DbContextOptions<AutoRaceContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
