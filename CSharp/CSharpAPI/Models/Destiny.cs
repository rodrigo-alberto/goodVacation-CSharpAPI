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

    [Column("state")]
    public string State { get; set; } = string.Empty;

    [Column("description")]
    public string Description { get; set; } = string.Empty;
    
    [Column("imageUrls")]
    public string[] ImageUrls { get; set; } = new string[5];
  }
}