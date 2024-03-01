using SabeelAPI.Models;

namespace SabeelAPI.DTO.Response
{
  public class EventAndImage
  {
    public  required Event Event { get; set; }
    public required Image Images { get; set; }
  }
}
