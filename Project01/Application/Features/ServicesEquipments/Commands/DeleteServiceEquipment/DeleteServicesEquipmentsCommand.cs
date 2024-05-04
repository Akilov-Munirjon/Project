using MediatR;

namespace Project01.Application.Features.ServicesEquipments.Commands.DeleteServicesEquipment
{
    public class DeleteServicesEquipmentsCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
