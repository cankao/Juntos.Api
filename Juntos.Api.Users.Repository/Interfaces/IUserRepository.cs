using Juntos.Api.Users.Domain.DTOs;

namespace Juntos.Api.Users.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        Task<int> Insert(UserDTO obj);

        Task<int> Update(UserDTO obj);

        Task<int> Delete(UserDTO obj);
    }


}
