using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities
{
    public class Disk : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Guid DiskTypeId { get; set; }

        public DiskType DiskType { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}