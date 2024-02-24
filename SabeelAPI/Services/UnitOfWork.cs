using Microsoft.EntityFrameworkCore;
using SabeelAPI.DB;
using SabeelAPI.IService;
using SabeelAPI.Models;

namespace SabeelAPI.Services
{
  public class UnitOfWork:IUnitOfWork
  {
    private ApplicationDbContext _dbContext;
    public IGenericRepository<Details> Details { get; private set; }
    public IGenericRepository<Contacts> Contacts { get; private set; }
    public IGenericRepository<TeemMember> TeemMembers { get; private set; }
    public IGenericRepository<Event> Events { get; private set; }

    public UnitOfWork(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
      Details = new GenericRepository<Details>(_dbContext);
      Contacts = new GenericRepository<Contacts>(_dbContext);
      TeemMembers = new GenericRepository<TeemMember>(_dbContext);
      Events = new GenericRepository<Event>(_dbContext);
    }



    public int Complete()
    {
      return _dbContext.SaveChanges();
    }
    public void Dispose()
    {
      _dbContext.Dispose();
    }
  }
}
