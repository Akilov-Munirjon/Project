using MediatR;

namespace Project01.Core.Controllers
{
    public class CreateDiskCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid DiskTypeId { get; set; }
    }
}