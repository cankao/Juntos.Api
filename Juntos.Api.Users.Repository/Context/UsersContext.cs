using Juntos.Api.Users.Domain.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Juntos.Api.Users.Infrastructure.Context
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options) 
        { 
        }


        public DbSet<UserDTO> Users { get; set; }
    }
}
