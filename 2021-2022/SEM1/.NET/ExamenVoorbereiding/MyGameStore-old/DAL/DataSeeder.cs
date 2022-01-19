using Microsoft.EntityFrameworkCore;
using MyGameStore.Model;

namespace MyGameStore.DAL
{
    public static class DataSeeder
    {
        public static void SeedPersons(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person(-1, -1, "van der Avoirt", "Jef", 0, "jef.v.d.a@live.be"),
                new Person(-2, -2, "Baeten", "Jens", 0, "baetenjens@gmail.com")
            );
        }

        public static void SeedStores(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>().HasData(
                new Store(-1, "MyGameStore Kortrijk", "Korte Steenstraat", "260", "", "8500", "Kortrijk", false),
                new Store(-2, "MyGameStore Ninove", "Centrumlaan", "95", "", "9400", "Ninove", true),
                new Store(-3, "MyGameStore Roeselare", "Ooststraat", "97", "", "8800", "Roeselare", false),
                new Store(-4, "MyGameStore Zaventem", "Weiveldlaan", "173", "", "1930", "Zaventem", false),
                new Store(-5, "MyGameStore Hasselt", "Demerstraat", "254", "", "3500", "Hasselt", false),
                new Store(-6, "MyGameStore Gent", "Veldstraat", "128", "", "9000", "Gent", true),
                new Store(-7, "MyGameStore Knokke-Heist", "Lippenslaan", "215", "", "8300", "Knokke-Heist", false),
                new Store(-8, "MyGameStore Maaseik", "Bosstraat", "239", "", "3680", "Maaseik", false),
                new Store(-9, "MyGameStore Beringen", "Koolmijnlaan", "85", "", "3580", "Beringen", false),
                new Store(-10, "MyGameStore Geraardsbergen", "Winkelstraat", "149", "", "9500", "Geraardsbergen", false),
                new Store(-11, "MyGameStore Asse", "Stationsstraat", "260", "", "1730", "Asse", false),
                new Store(-12, "MyGameStore Geel", "Nieuwstraat", "59", "", "2440", "Geel", false),
                new Store(-13, "MyGameStore Antwerpen", "Meir", "76", "", "2000", "Antwerpen", true),
                new Store(-14, "MyGameStore Mol", "Statiestraat", "179", "", "2400", "Mol", false),
                new Store(-15, "MyGameStore Sint-Gillis", "Fonsnylaan", "286", "", "1060", "Sint-Gillis", false)
            );
        }
    }
}
