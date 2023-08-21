namespace Application.Exceptions;

public class SaleNotFoundException : Exception
{

    public SaleNotFoundException(int saleId) : base($"Sale with ID {saleId} was not found.")
    {
    }

}