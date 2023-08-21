using Domain.Entities;

namespace Application.Interfaces;

public interface ISaleService
{

    Sale CreateSale(int productId, int quantity);

}