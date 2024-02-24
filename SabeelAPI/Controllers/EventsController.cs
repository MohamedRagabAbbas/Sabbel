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
    public IActionResult Get()
    {
      var events = _unitOfWork.Events.GetAll();
      return Ok(events);
    }
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("Add")]
    public IActionResult Add(Event events)
    {
      _unitOfWork.Events.Add(events);
      _unitOfWork.Complete();
      return Ok(events);
    }
    [Authorize(Roles = "Admin")]
    [HttpPut]
    [Route("Update")]
    public IActionResult Update(Event events)
    {
      _unitOfWork.Events.Update(events);
      _unitOfWork.Complete();
      return Ok(events);
    }
    [Authorize(Roles = "Admin")]
    [HttpDelete]
    [Route("Delete")]
    public IActionResult Delete(int id)
    {
      _unitOfWork.Events.Delete(id);
      _unitOfWork.Complete();
      return Ok(id);
    }
  }
}
