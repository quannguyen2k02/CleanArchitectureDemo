using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities;
[Table("Product")]
public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    [JsonIgnore]
    public ICollection<OrderDetail>? Products { get; set; }
}
