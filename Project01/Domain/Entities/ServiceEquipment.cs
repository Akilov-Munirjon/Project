using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities
{
    public class ServiceEquipment : BaseEntity
    {
        public Guid EquipmentId { get; set; }
        public Guid ServiceId   { get; set; }

        public Service Service { get; set; }
        public Equipment Equipment { get; set; }
    }
}
