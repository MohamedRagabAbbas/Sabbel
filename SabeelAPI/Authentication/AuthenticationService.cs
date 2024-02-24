using Microsoft.AspNetCore.Identity;
using SabeelAPI.DTO.Request;
using SabeelAPI.DTO.Response;
using SabeelAPI.IService;
using SabeelAPI.Models;

namespace SabeelAPI.Authentication
{
  public class AuthenticationService
  {
    private readonly UserManager<User> _userManager;
    private readonly Token _token;
    private readonly IUnitOfWork _unitOfWork;
    public AuthenticationService(UserManager<User> userManager, Token token, IUnitOfWork unitOfWork)
    {
      _userManager = userManager;
      _token = token;
      _unitOfWork = unitOfWork;
    }
    public async Task<AuthenticationResponse> Authenticate(string email, string password)
    {
      var user = await _userManager.FindByNameAsync(email);
      if (user != null && await _userManager.CheckPasswordAsync(user, password))
      {
        var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
        if (role != null)
        {
          if (role == "Admin")
          {
            return new AuthenticationResponse()
            {
              Id = user.Id,
              Role = role,
              IsAuthenticated = true,
              Token = _token.GenerateToken(user.Id)
            };
          }
        }
        return new AuthenticationResponse();
      }
      return new AuthenticationResponse();
    }
    // job seeker register
    public async Task<AuthenticationResponse> Register(RegistrationRequest model)
    {
      var user = new User()
      {
        Email = model.Email,
        FirstName = model.FirstName,
        LastName = model.LastName,
        // unused properties
        UserName = model.Email
      };
      var result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        //add Role
        await _userManager.AddToRoleAsync(user, "Admin");
          return new AuthenticationResponse()
          {
            Id = user.Id,
            Role = "Admin",
            IsAuthenticated = true,
            Token = _token.GenerateToken(user.Id)
          };
      }
      var errors = result.Errors.ToList();
      string Error = "";
      foreach (var item in errors)
      {
        Error += item.Description + " ";
      }
      return new AuthenticationResponse() { Message = Error };
    }
    
  }
}
