using MediatR;

namespace Project01.Application.Features.DiskTypes.Commands.UpdateDiskType
{
    public class UpdateDiskTypeCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Size { get; set; }
        public string Collor { get; set; }
    }
}
