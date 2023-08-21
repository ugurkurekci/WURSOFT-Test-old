using Application.DTOs;
using MediatR;

namespace Application.Queries;

public class GetSaleQuery : IRequest<SaleDto>
{

    public int SaleId { get; set; }

}