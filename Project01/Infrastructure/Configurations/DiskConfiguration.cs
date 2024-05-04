using Project01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Project01.Infrastructure.Configurations
{
    public class DiskConfiguration : IEntityTypeConfiguration<Disk>
    {
        public void Configure(EntityTypeBuilder<Disk> builder)
        {
            builder.Property(d => d.Id)
                   .IsRequired();

            builder.Property(c => c.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(d => d.Price)
                   .IsRequired();

            builder.HasOne(d => d.DiskType)
                   .WithMany(d => d.Disks)
                   .HasForeignKey(d => d.DiskTypeId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

        }
    }
}

