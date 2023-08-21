using Application.DTOs;
using MediatR;

namespace Application.Commands;

public class CreateSaleCommand : IRequest<SaleDto>
{

    public int ProductId { get; set; }

    public int Quantity { get; set; }

}