using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserCommand, User>();
        }
    }
}