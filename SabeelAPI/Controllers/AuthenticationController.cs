using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SabeelAPI.Authentication;
using SabeelAPI.DTO.Request;

namespace SabeelAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthenticationController : ControllerBase
  {
    private readonly AuthenticationService _authenticationService;
    public AuthenticationController(AuthenticationService authenticationService)
    {
      _authenticationService = authenticationService;
    }
    [Route("login/{email}/{password}")]
    [HttpPost]
    public async Task<IActionResult> Login(string email, string password)
    {
      var response = await _authenticationService.Authenticate(email, password);
      return Ok(response);
    }
    [Route("register")]
    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegistrationRequest model)
    {
      var response = await _authenticationService.Register(model);
      return Ok(response);
    }

  }
}
