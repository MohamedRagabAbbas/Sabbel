namespace SabeelAPI.Models
{
  public class Event
  {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Image? Image { get; set; }
    public string price { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;
    public string Duration { get; set; } = string.Empty;
    public bool IsNonAucianAllowed { get; set; } = false;
  }
}
