using Project01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project01.Infrastructure.Configurations
{
    public class TireConfiguration : IEntityTypeConfiguration<Tire>
    {
        public void Configure(EntityTypeBuilder<Tire> builder)
        {
            builder.Property(t => t.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(t => t.Size)
                   .IsRequired();

            builder.Property(t => t.Price)
                   .IsRequired();

            builder.HasOne(t => t.TireType)
                   .WithMany(t => t.Tires)
                   .HasForeignKey(d => d.TireTypeId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();
        }
    }
}