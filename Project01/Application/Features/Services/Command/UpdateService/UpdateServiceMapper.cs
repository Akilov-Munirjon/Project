using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Services.Command.UpdateService
{
    public class UpdateServiceMapper : Profile
    {
        public UpdateServiceMapper()
        {
            CreateMap<UpdateServiceCommand, Service>();
        }
    }
}
