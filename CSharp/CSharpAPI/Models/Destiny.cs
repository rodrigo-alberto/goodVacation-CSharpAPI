using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpAPI.Models
{
  [Table("destiny")]
  public class Destiny
  {
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    // public ArrayList? ImageUrls { get; set; }
    public string[] ImageUrls = new string[5];

    public string City { get; set; } = string.Empty;
    
  }
}