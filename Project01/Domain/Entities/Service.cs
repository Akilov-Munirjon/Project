using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<ServiceEquipment> ServicesEquipments { get; set; }
    }
}
