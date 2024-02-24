using SabeelAPI.DTO.Response;
using System.Linq.Expressions;

namespace SabeelAPI.IService
{
  public interface IGenericRepository<T> where T : class 
  {
    Task<ServerResponse<IEnumerable<T>>> GetAll();
    Task<ServerResponse<T>> GetById(int id);
    Task<ServerResponse<T>> FindFirst(Expression<Func<T, bool>> predicate);
    Task<ServerResponse<IEnumerable<T>>> Find(Expression<Func<T, bool>> predicate);
    Task<ServerResponse<T>> Add(T entity);
    ServerResponse<T> Update(T entity);
    Task<ServerResponse<T>> Delete(int id);
  }
}
