namespace SabeelAPI.Models
{
  public class Event
  {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string price { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Duration { get; set; } = string.Empty;
    public bool IsNonAucianAllowed { get; set; } = false;
  }
}
