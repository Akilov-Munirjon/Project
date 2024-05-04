using MediatR;

namespace Project01.Application.Features.DiskTypes.Commands
{
    public class CreateDiskTypeCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public decimal Size { get; set; }
        public string Collor { get; set; }
    }
}
