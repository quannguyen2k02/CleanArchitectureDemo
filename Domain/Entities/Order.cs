using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
[Table("Order")]
public class Order
{
    public int Id { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public decimal TotalPrice { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}
