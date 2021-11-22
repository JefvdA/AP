using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("tblStores", "Store")
                .HasKey(s => s.ID);

            builder.Property(s => s.Name)
                .HasMaxLength(30)
                .IsRequired();
            builder.HasIndex(s => s.Name)
                .IsUnique();

            builder.Property(s => s.Street)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(s => s.Number)
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(s => s.Addition)
                .HasMaxLength(2);

            builder.Property(s => s.Zipcode)
                .HasMaxLength(6)
                .IsRequired();

            builder.Property(s => s.City)
                .HasMaxLength(60)
                .HasColumnName("Place");
        }
    }
}
