using Domain.Model;

namespace Infrastructure.Repositories;

public class SaleRepository
{

    public void SaveSale(Sale sale)
    {
        // Sale nesnesini veritabanına kaydetme işlemi
    }

    public Product GetProduct(int productId)
    {
        // Ürün bilgisini veritabanından çekme işlemi
        return new Product();
    }

}