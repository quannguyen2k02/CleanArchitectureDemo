namespace Domain.Models;


public class OrderDTO
{
    public int Id { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public decimal TotalPrice { get; set; }
    public ICollection<OrderDetailDTO> OrderDetails { get; set; }
}
