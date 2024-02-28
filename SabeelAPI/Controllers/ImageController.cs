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
    [Route("Upload/{id}")]
    public async Task<IActionResult> Upload(IFormFile file,int id)
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

  }
}
