using System.Text.Json.Serialization;
namespace Domain.Models;

public class ProductDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    [JsonIgnore]
    public ICollection<OrderDetailDTO>? Products { get; set; }
}
