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
    public IActionResult Get()
    {
      var teem = _unitOfWork.TeemMembers.GetAll();
      return Ok(teem);
    }
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("Add")]
    public IActionResult Add(TeemMember teem)
    {
      _unitOfWork.TeemMembers.Add(teem);
      _unitOfWork.Complete();
      return Ok(teem);
    }
    [Authorize(Roles = "Admin")]
    [HttpPut]
    [Route("Update")]
    public IActionResult Update(TeemMember teem)
    {
      _unitOfWork.TeemMembers.Update(teem);
      _unitOfWork.Complete();
      return Ok(teem);
    }
    [Authorize(Roles = "Admin")]
    [HttpDelete]
    [Route("Delete")]
    public IActionResult Delete(int id)
    {
      _unitOfWork.TeemMembers.Delete(id);
      _unitOfWork.Complete();
      return Ok(id);
    }
  }
}
