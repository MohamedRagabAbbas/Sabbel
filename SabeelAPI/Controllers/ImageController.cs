using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SabeelAPI.IService;
using SabeelAPI.Models;

namespace SabeelAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ImageController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;
    public ImageController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpPost]
    [Route("Upload-Image-Event/{id}")]
    public async Task<IActionResult> UploadImageEvent(IFormFile file,int id)
    {
      var Image = new Image();
      Image.EventId = id;
      Image.ImageData = new byte[file.Length];
      using (var stream = new MemoryStream())
      {
        await file.CopyToAsync(stream);
        Image.ImageData = stream.ToArray();
      }
      var response = await _unitOfWork.Images.Add(Image);
      return Ok(response);
    }
    [HttpPost]
    [Route("Upload-Image-Member/{id}")]
    public async Task<IActionResult> UploadImageMember(IFormFile file, int id)
    {
      var Image = new Image();
      Image.TeamMemberId = id;
      Image.ImageData = new byte[file.Length];
      using (var stream = new MemoryStream())
      {
        await file.CopyToAsync(stream);
        Image.ImageData = stream.ToArray();
      }
      var response = await _unitOfWork.Images.Add(Image);
      return Ok(response);
    }
    [HttpGet]
    [Route("GetImageByEventID")]
    public async Task<IActionResult> GetImageByEventID(int id)
    {
      var response = await _unitOfWork.Images.FindFirst(x => x.EventId == id);
      return Ok(response);
    }

  }
}
