using Application.DTOs;
using AutoMapper;
using Domain.Model;

namespace Application.Mappings;

public class MappingProfile : Profile
{

    public MappingProfile()
    {
        CreateMap<Sale, SaleDto>();
    }

}