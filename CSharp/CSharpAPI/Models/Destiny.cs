using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpAPI.Models
{
  [Table("destiny")]
  public class Destiny
  {
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("city")]
    public string City { get; set; } = string.Empty;

    // public ArrayList? ImageUrls { get; set; }
    // public string ImageUrl { get; set; } = string.Empty;
    [Column("imageUrls")]
    public string[] ImageUrls { get; set; } = new string[5];
    
  }
}