namespace SabeelAPI.Models
{
  public class Image
  {
    public int Id { get; set; }
    public byte[]? ImageData { get; set; }
    public string ImageDescription { get; set; } = string.Empty;

    public int EventId { get; set; }
    public Event? Event { get; set; }
    public int TeemMemberId { get; set; }
    public TeemMember? TeemMember { get; set; }
  }
}
