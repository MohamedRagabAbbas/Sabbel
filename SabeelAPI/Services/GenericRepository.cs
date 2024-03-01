using Microsoft.EntityFrameworkCore;
using SabeelAPI.DB;
using SabeelAPI.DTO.Response;
using SabeelAPI.IService;
using System.Linq.Expressions;

namespace SabeelAPI.Services
{
  public class GenericRepository<T> : IGenericRepository<T> where T : class
  {
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public async Task<ServerResponse<IEnumerable<T>>> GetAll()
    {
        var all = await _dbSet.ToListAsync();
        if(all is not null)
          return new ServerResponse<IEnumerable<T>> { IsSuccess = true, Data = all };
        return new ServerResponse<IEnumerable<T>> { IsSuccess = false, Message = "No data found" };
    }

    public async Task<ServerResponse<IEnumerable<T>>> GetAllWithInclude(List<string> includes)
    {
      var query = _dbSet.AsQueryable();
      foreach (var include in includes)
      {
        query = query.Include(include);
      }
      var all = await query.ToListAsync();
      if (all is not null)
        return new ServerResponse<IEnumerable<T>> { IsSuccess = true, Data = all };
      return new ServerResponse<IEnumerable<T>> { IsSuccess = false, Message = "No data found" };
    }
    public async Task<ServerResponse<T>> GetById(int id)
    {
      var obj = await _dbSet.FindAsync(id);
      if (obj is not null)
        return new ServerResponse<T>()
        {
          Message = "The object is successfully found...",
          IsSuccess = true,
          Data = obj
        };
      return new ServerResponse<T>() { Message = "The object is not found..." };
    }
    public async Task<ServerResponse<IEnumerable<T>>> Find(Expression<Func<T, bool>> predicate)
    {
      var objs = await _dbSet.Where<T>(predicate).ToListAsync();
      if (objs is not null)
        return new ServerResponse<IEnumerable<T>>()
        {
          Message = "The object is successfully found...",
          IsSuccess = true,
          Data = objs
        };
      return new ServerResponse<IEnumerable<T>>() { Message = "The object is not found..." };
    }

    public async Task<ServerResponse<T>> FindFirst(Expression<Func<T, bool>> predicate)
    {
      var obj = await _dbSet.Where<T>(predicate).FirstAsync();
      if (obj is not null)
        return new ServerResponse<T>()
        {
          Message = "The object is successfully found...",
          IsSuccess = true,
          Data = obj
        };
      return new ServerResponse<T>() { Message = "The object is not found..." };
    }

   

    public async Task<ServerResponse<T>> Add(T entity)
    {
      var obj = await _dbSet.AddAsync(entity);
      if (obj is not null)
        return new ServerResponse<T>()
        {
          Message = "This object is added successfully...",
          IsSuccess = true,
          Data = obj.Entity
        };
      return new ServerResponse<T>() { Message = "This object is not added..." };
    }

    public ServerResponse<T> Update(T entity)
    {
      var obj = _dbSet.Update(entity);
      if (obj is not null)
        return new ServerResponse<T>()
        {
          Message = "This object is updated successfully...",
          IsSuccess = true,
          Data = obj as T
        };
      return new ServerResponse<T>() { Message = "Cannot update this object..." };
    }
    public async Task<ServerResponse<T>> Delete(int id)
    {
      var model = await _dbSet.FindAsync(id);
      if (model is not null)
      {
        var obj = _dbSet.Remove(model);
        if (obj is not null)
          return new ServerResponse<T>()
          {
            Message = "This object is deleted Successfully...",
            IsSuccess = true,
            Data = obj as T
          };
        return new ServerResponse<T>() { Message = "Cannot delete this object" };
      }
      return new ServerResponse<T>() { Message = "Cannot find this object" };
    }
  }
}
