namespace Juntos.Api.Users.Infrastructure.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> InsertAsync(T obj);

        Task<int> UpdateAsync(T obj);

        Task<int> DeleteAsync(T obj);
    }
}
