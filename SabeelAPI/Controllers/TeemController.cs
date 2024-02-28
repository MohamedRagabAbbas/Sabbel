using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SabeelAPI.IService;
using SabeelAPI.Models;
using System.Data;

namespace SabeelAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TeemController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;
    public TeemController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<IActionResult> Get()
    {
      var response = await _unitOfWork.TeemMembers.GetAll();
      return Ok(response);
    }
    [Authorize]
    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Add(TeemMember teem)
    {
      var response = await  _unitOfWork.TeemMembers.Add(teem);
      _unitOfWork.Complete();
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpPut]
    [Route("Update")]
    public IActionResult Update(TeemMember teem)
    {
      var response =  _unitOfWork.TeemMembers.Update(teem);
      _unitOfWork.Complete();
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpDelete]
    [Route("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
      var response = await _unitOfWork.TeemMembers.Delete(id);
      _unitOfWork.Complete();
      return Ok(response);
    }
  }
}
