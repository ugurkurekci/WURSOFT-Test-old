namespace Domain.Aggregates;

public class OrderItem
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
