using MediatR;

namespace Project01.Application.Features.Equipments.Queries.GetAllEquipment
{
    public class GetAllEquipmentQuery : IRequest<List<GetAllEquipmentViewModel>>
    {
    }
}
