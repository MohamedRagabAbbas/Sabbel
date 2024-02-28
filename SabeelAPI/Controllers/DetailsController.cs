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
    public async Task<IActionResult> Get()
    {
      var response = await _unitOfWork.Details.GetAll();
      return Ok(response);
    }
    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var response = await _unitOfWork.Details.GetById(id);
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Add(Details details)
    {
      var response = await _unitOfWork.Details.Add(details);
      _unitOfWork.Complete();
      return Ok(response);
    }
    [Authorize]
    [HttpPut]
    [Route("Update")]
    public IActionResult Update([FromBody]Details details)
    {
      var response =  _unitOfWork.Details.Update(details);
      _unitOfWork.Complete();
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpDelete]
    [Route("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
      var response = await _unitOfWork.Details.Delete(id);
      _unitOfWork.Complete();
      return Ok(response);
    }

  }
}
