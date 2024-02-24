using System;

namespace SabeelAPI.Models
{
  public class Details
  {
    public int Id { get; set; }
    public string About { get; set; } = string.Empty;
    public string Mission { get; set; } = string.Empty;
    public string vision { get; set; } = string.Empty;
    public string EventsGoal { get; set; } = string.Empty;
    // Achievemtns in Numbers
    public int YearsOfExperience { get; set; }
    public int Attendees { get; set; }
    public int Events { get; set; }
    public int funds { get; set; }
  }
}
