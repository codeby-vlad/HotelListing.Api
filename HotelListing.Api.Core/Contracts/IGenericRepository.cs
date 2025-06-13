using HotelListing.Api.Core.Models;

namespace HotelListing.Api.Core.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        // TResult - mapped Dto object that was returned to the client from database ()
        // TSource - Dto object that has been sent to the methods which work with database operations (While using /post and /put we accept only Dto objects)
        // The main point of use <TResult> and <TSource> - move mapping logic from controllers directly to GenericRepository methods
        Task<T> GetAsync(int? id);
        Task<TResult> GetAsync<TResult>(int? id);
        Task<List<T>> GetAllAsync();
        Task<List<TResult>> GetAllAsync<TResult>() where TResult : class;
        Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);
        Task<T> AddAsync(T entity);
        Task<TResult> AddAsync<TSource, TResult>(TSource source);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task UpdateAsync<TSource>(int id, TSource source);
        Task<bool> Exists(int id);
    }
}
