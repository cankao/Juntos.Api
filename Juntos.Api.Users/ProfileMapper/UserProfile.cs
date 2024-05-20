using AutoMapper;
using Juntos.Api.Users.Domain.DTOs;
using Juntos.Api.Users.Domain.Requests;
using Juntos.Api.Users.Domain.Responses;

namespace Juntos.Api.Users.App.ProfileMapper
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<UserRequest, UserDTO>();
            CreateMap<UserDTO, UserResponse>();
        }

    }
}
