using Project01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project01.Infrastructure.Configurations
{
    public class DiskTypeConfiguration : IEntityTypeConfiguration<DiskType>
    {
        public void Configure(EntityTypeBuilder<DiskType> builder)
        {
            builder.Property(d => d.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(d => d.Size)
                   .IsRequired();

            builder.Property(d => d.Collor)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}