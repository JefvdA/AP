using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.DAL.Model;

namespace MyGameStore.DAL.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder
                .ToTable("tblStores", "Store")
                .HasKey(s => s.Id);

            builder.Property("Name")
                .HasMaxLength(30)
                .IsRequired();

            builder
                .HasIndex(s => s.Name)
                .IsUnique();

            builder.Property("Street")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property("Number")
                .HasMaxLength(5)
                .IsRequired();

            builder.Property("Addition")
                .HasMaxLength(2);

            builder.Property("Zipcode")
                .HasMaxLength(6)
                .IsRequired();

            builder.Property("City")
                .HasMaxLength(60)
                .HasColumnName("Place");
        }
    }
}
