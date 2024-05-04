using Project01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project01.Infrastructure.Configurations
{
    public class TireTypeConfiguration : IEntityTypeConfiguration<TireType>
    {
        public void Configure(EntityTypeBuilder<TireType> builder)
        {
            builder.Property(tt => tt.Name)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}