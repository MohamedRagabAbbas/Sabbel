namespace SabeelAPI.Models
{
  public class TeemMember
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Postion = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Image? Image { get; set; }
  }
}
