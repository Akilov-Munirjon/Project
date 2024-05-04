using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Domain.Entities;

namespace Project01.Infrastructure.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Name)
                   .IsRequired();

            builder.Property(o => o.Numbercar)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(o => o.Phonenumber)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.HasOne(d => d.Disk)
                   .WithMany(d => d.Orders)
                   .HasForeignKey(d => d.DiskId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired(false);

            builder.HasOne(t => t.Tire)
                   .WithMany(d => d.Orders)
                   .HasForeignKey(d => d.TireId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired(false);

            builder.HasOne(u => u.User)
                   .WithMany(o => o.Orders)
                   .HasForeignKey(u => u.UserId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

            builder.HasOne(u => u.Service)
                   .WithMany(c => c.Orders)
                   .HasForeignKey(u => u.ServiceId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();
        }
    }
}
