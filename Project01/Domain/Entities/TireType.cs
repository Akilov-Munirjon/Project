using Project01.Domain.Common.BaseEntities;

namespace Project01.Domain.Entities;

public class TireType : BaseEntity
{
    public string Name { get; set; }

    public ICollection<Tire> Tires { get; set; } = new List<Tire>();
}
