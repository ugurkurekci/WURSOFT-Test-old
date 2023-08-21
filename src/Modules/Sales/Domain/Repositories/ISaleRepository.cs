using Domain.Entities;

namespace Domain.Repositories;

public interface ISaleRepository
{

    void SaveSale(Sale sale);

    Sale GetSaleById(int saleId);

}