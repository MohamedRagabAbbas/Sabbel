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
  public class EventsController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;
    public EventsController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<IActionResult> Get()
    {
      var response = await _unitOfWork.Events.GetAll();
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Add(Event events)
    {
      var response = await _unitOfWork.Events.Add(events);
      _unitOfWork.Complete();
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpPut]
    [Route("Update")]
    public IActionResult Update(Event events)
    {
      var response  = _unitOfWork.Events.Update(events);
      _unitOfWork.Complete();
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpDelete]
    [Route("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
      var response = await _unitOfWork.Events.Delete(id);
      _unitOfWork.Complete();
      return Ok(response);
    }
  }
}
