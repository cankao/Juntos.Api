using Juntos.Api.Users.Infrastructure.Context;
using Juntos.Api.Users.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Juntos.Api.Users.Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected UsersContext _context;


        public BaseRepository(UsersContext context)
        {
            _context = context;
        }

        public Task<int> InsertAsync(T obj)
        {
            _context.Set<T>().Add(obj);
            return _context.SaveChangesAsync();
        }

        public Task<int> UpdateAsync(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public Task<int> DeleteAsync(T obj)
        {
            _context.Set<T>().Remove(obj);
            return _context.SaveChangesAsync();
        }
    }
}
