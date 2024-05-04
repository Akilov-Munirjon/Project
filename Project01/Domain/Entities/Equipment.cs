using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities
{
    public class Equipment : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<ServiceEquipment> ServicesEquipments { get; set; } = new List<ServiceEquipment>();
    }
}
