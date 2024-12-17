using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
[Table("OrderDetail")]
public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Price { get; set; }

}
