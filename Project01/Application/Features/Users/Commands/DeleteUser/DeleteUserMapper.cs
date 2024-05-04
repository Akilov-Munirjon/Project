using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Users.Commands.DeleteUser
{
    public class DeleteUserMapper : Profile
    {
        public DeleteUserMapper()
        {
            CreateMap<DeleteUserCommand, User>();
        }
    }
}
