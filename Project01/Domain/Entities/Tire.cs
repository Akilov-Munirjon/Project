using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities
{
    public class Tire : BaseEntity
    {
        public string Name { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }

        public Guid TireTypeId { get; set; }
        public TireType TireType { get; set; } 

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
