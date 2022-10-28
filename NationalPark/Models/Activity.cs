using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace National.Models
{
  public class Activity{
    public int ActivityId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Type { get; set;}
    [Required]
    public int Size { get; set; }
    [JsonIgnore]
    public virtual Park Park { get; set;}
  }
}