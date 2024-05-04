using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project01.Domain.Entities;

namespace Project01.Infrastructure.Configurations
{
    public class ServicesEquipmentsConfiguration : IEntityTypeConfiguration<ServiceEquipment>
    {
        public void Configure(EntityTypeBuilder<ServiceEquipment> builder)
        {
            builder.HasOne(se => se.Equipment)
                   .WithMany(e => e.ServicesEquipments)
                   .HasForeignKey(se => se.EquipmentId)  
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

            builder.HasOne(se => se.Service)
                   .WithMany(s => s.ServicesEquipments)
                   .HasForeignKey(se => se.ServiceId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();
        }
    }
}
