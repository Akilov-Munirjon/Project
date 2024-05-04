using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllUserMapper : Profile
    {
        public GetAllUserMapper()
        {
            CreateMap<User, GetAllUserViewModel>();
        }
    }
}
