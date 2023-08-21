namespace Domain.Entities;

public class Customer
{

    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public decimal Balance { get; set; }

    public void AddTransaction(decimal amount)
    {
        Balance += amount;
    }

    public void UpdateEmail(string newEmail)
    {
        Email = newEmail;
    }

}