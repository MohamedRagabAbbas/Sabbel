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
  public class DetailsController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;
    public DetailsController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [Route("GetAll")]
    public IActionResult Get()
    {
      var details = _unitOfWork.Details.GetAll();
      return Ok(details);
    }
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("Add")]
    public IActionResult Add(Details details)
    {
      _unitOfWork.Details.Add(details);
      _unitOfWork.Complete();
      return Ok(details);
    }
    [Authorize(Roles = "Admin")]
    [HttpPut]
    [Route("Update")]
    public IActionResult Update(Details details)
    {
      _unitOfWork.Details.Update(details);
      _unitOfWork.Complete();
      return Ok(details);
    }
    [Authorize(Roles = "Admin")]
    [HttpDelete]
    [Route("Delete")]
    public IActionResult Delete(int id)
    {
      _unitOfWork.Details.Delete(id);
      _unitOfWork.Complete();
      return Ok(id);
    }

  }
}
