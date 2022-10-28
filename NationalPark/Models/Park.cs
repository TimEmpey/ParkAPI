using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace National.Models
{
  public class Park
  {
    public Park()
    {
      this.Activities = new HashSet<Activity>();
    }
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public string Camping { get; set;}
    public ICollection<Activity> Activities { get; set; }
  }
}