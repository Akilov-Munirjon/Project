using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.TireTypes.Commands.CreateTireType
{
    public class CreateTireTypeMapper : Profile
    {
        public CreateTireTypeMapper()
        {
            CreateMap<CreateTireTypeCommand, TireType>();
        }
    }
}
