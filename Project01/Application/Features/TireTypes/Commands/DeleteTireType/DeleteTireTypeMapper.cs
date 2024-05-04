using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.TireTypes.Commands.DeleteTireType
{
    public class DeleteTireTypeMapper : Profile
    {
        public DeleteTireTypeMapper()
        {
            CreateMap<DeleteTireTypeCommand, TireType>();
        }
    }
}
