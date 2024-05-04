using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Services.Command
{
    public class CreateServiceMapper : Profile
    {
        public CreateServiceMapper()
        {
            CreateMap<CreateServiceCommand, Service>();
        }
    }
}
