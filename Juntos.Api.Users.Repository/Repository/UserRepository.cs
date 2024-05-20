using Juntos.Api.Users.Domain.DTOs;
using Juntos.Api.Users.Infrastructure.Context;
using Juntos.Api.Users.Infrastructure.Interfaces;

namespace Juntos.Api.Users.Infrastructure.Repository
{
    public class UserRepository : BaseRepository<UserDTO>, IUserRepository
    {
        public UserRepository(UsersContext context) : base(context)
        {
        }

        public Task<int> Delete(UserDTO obj)
        {
            return DeleteAsync(obj);    
        }

        public Task<int> Insert(UserDTO obj)
        {
            return DeleteAsync(obj);
        }

        public Task<int> Update(UserDTO obj)
        {
            return UpdateAsync(obj);
        }
    }
}
