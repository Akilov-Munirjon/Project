using Project01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project01.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.LastName)
                   .IsRequired()
                   .HasMaxLength(100);


            builder.Property(u => u.MiddleName)
                  .IsRequired()
                  .HasMaxLength(100);


            builder.Property(u => u.Password)
                  .IsRequired()
                  .HasMaxLength(100);


            builder.Property(u => u.Login)
                  .IsRequired()
                  .HasMaxLength(100);

        }
    }
}