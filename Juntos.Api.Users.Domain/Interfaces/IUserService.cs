using Juntos.Api.Users.Domain.DTOs;
using Juntos.Api.Users.Domain.Requests;
using Juntos.Api.Users.Domain.Responses;

namespace Juntos.Api.Users.Domain.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> Insert(UserRequest user);
        Task<UserDTO> Update(UserRequest user);
        Task<UserDTO> Delete(UserRequest user);
    }
}
