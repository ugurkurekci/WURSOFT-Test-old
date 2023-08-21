namespace Domain.Entities;

public class Sale
{

    public int Id { get; set; }

    public Product Product { get; set; }

    public int Quantity { get; set; }

    public decimal TotalAmount { get; set; }

}