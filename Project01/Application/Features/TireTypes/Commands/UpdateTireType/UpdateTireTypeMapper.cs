using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.TireTypes.Commands.UpdateTireType
{
    public class UpdateTireTypeMapper : Profile
    {
        public UpdateTireTypeMapper()
        {
            CreateMap<UpdateTireTypeCommand, TireType>();
        }
    }
}
