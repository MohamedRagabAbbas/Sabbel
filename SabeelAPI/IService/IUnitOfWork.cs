using SabeelAPI.Models;
using static System.Net.Mime.MediaTypeNames;

namespace SabeelAPI.IService
{
  public interface IUnitOfWork: IDisposable
  {
    IGenericRepository<Details> Details { get; }
    IGenericRepository<Contacts> Contacts { get; }
    IGenericRepository<TeemMember> TeemMembers { get; }
    IGenericRepository<Event> Events { get; }

    int Complete();
  }
}
