using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SabeelAPI.IService;
using SabeelAPI.Models;

namespace SabeelAPI.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class ContactsController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;
    public ContactsController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [Route("GetAll")]
    public IActionResult Get()
    {
      var contacts = _unitOfWork.Contacts.GetAll();
      return Ok(contacts);
    }
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("Add")]
    public IActionResult Add(Contacts contacts)
    {
      _unitOfWork.Contacts.Add(contacts);
      _unitOfWork.Complete();
      return Ok(contacts);
    }
    [Authorize(Roles = "Admin")]
    [HttpPut]
    [Route("Update")]
    public IActionResult Update(Contacts contacts)
    {
      _unitOfWork.Contacts.Update(contacts);
      _unitOfWork.Complete();
      return Ok(contacts);
    }
    [Authorize(Roles = "Admin")]
    [HttpDelete]
    [Route("Delete")]
    public IActionResult Delete(int id)
    {
      _unitOfWork.Contacts.Delete(id);
      _unitOfWork.Complete();
      return Ok(id);
    }
  }
}
