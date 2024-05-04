using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities
{
    public class DiskType : BaseEntity
    {
        public string Name { get; set; }
        public decimal Size { get; set; }
        public string Collor { get; set; }

        public ICollection<Disk> Disks { get; set; } = new List<Disk>();

    }
}
