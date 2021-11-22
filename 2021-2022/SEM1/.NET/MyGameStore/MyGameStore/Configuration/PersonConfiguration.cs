using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("tblPeople", "Person")
                .HasKey(p => p.ID);

            builder.Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasMaxLength(100)
                .HasColumnName("EmailAddress");

            builder.HasIndex(p => p.Email)
                .IsUnique();
        }
    }
}
