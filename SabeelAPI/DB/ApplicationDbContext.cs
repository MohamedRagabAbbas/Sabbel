using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SabeelAPI.Models;

namespace SabeelAPI.DB
{
  public class ApplicationDbContext: IdentityDbContext
  {
    public DbSet<Details> Details { get; set; }
    public DbSet<TeemMember> TeemMembers { get; set; } 
    public DbSet<Event> Events { get; set; }
    public DbSet<Contacts> Contacts { get; set; }
 

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {

    }


  }
}
