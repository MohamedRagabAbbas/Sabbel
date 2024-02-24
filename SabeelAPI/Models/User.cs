using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace SabeelAPI.Models
{
  public class User:IdentityUser
  {
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = String.Empty;
  }
}
