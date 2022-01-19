using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.DAL.Model;

namespace MyGameStore.DAL.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .ToTable("tblPeople", "Person")
                .HasKey(p => p.Id);

            builder.Property("FirstName")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property("LastName")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property("Email")
                .HasMaxLength(100)
                .HasColumnName("EmailAdress");

            builder.HasIndex(p => p.Email)
                .IsUnique();
        }
    }
}
