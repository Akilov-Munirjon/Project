using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserMapper : Profile
    {
        public UpdateUserMapper()
        {
            CreateMap<UpdateUserCommand, User>();
        }
    }
}
