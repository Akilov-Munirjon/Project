using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Name { get; set; }
        public string Numbercar { get; set; }
        public string Phonenumber { get; set; } 

        public Guid? TireId { get; set; } 
        public Guid? DiskId { get; set; }
        public Guid UserId { get; set; }
        public Guid ServiceId { get; set; }

        public Disk Disk { get; set; }
        public Tire Tire { get; set; }
        public User User { get; set; }
        public Service Service { get; set; }
    }
}
