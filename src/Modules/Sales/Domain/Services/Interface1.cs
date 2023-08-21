using Domain.Entities;

namespace Domain.Services;

public interface ISaleService
{

    Sale CreateSale(int productId, int quantity);

}