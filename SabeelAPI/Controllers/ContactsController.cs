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
    public async Task<IActionResult> Get()
    {
      var response = await _unitOfWork.Contacts.GetAll();
      return Ok(response);
    }
    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
      var response = await _unitOfWork.Contacts.GetById(id);
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Add(Contacts contacts)
    {
      var response = await _unitOfWork.Contacts.Add(contacts);
      _unitOfWork.Complete();
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpPut]
    [Route("Update")]
    public  IActionResult Update(Contacts contacts)
    {
      var response =  _unitOfWork.Contacts.Update(contacts);
      _unitOfWork.Complete();
      return Ok(response);
    }
    [Authorize(Roles = "Admin")]
    [HttpDelete]
    [Route("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
      var response = await _unitOfWork.Contacts.Delete(id);
      _unitOfWork.Complete();
      return Ok(response);
    }
  }
}
