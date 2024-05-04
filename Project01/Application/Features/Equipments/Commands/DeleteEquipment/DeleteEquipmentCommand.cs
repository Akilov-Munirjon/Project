using MediatR;

namespace Project01.Application.Features.Equipments.Commands.DeleteEquipment
{
    public class DeleteEquipmentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
