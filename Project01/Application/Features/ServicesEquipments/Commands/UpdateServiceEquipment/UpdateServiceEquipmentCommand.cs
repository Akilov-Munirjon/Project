using MediatR;

namespace Project01.Application.Features.ServicesEquipments.Commands.UpdateServiceEquipment
{
    public class UpdateServiceEquipmentCommand : IRequest
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public string EquipmentName { get; set; }
    }
}
