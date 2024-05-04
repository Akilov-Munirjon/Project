using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Services.Command.DeleteService;

public class DeleteServiceMapper : Profile
{
    public DeleteServiceMapper()
    {
        CreateMap<DeleteServiceCommand, Service>();
    }
}
