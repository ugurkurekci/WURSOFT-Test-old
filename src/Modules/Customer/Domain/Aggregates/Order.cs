namespace Domain.Aggregates;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<OrderItem> Items { get; set; }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
        TotalAmount += item.Price * item.Quantity;
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
        TotalAmount -= item.Price * item.Quantity;
    }
}
