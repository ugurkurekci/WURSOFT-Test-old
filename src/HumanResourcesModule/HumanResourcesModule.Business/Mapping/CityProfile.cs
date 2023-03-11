using AutoMapper;
using HumanResourcesModule.Business.Dto;
using HumanResourcesModule.Repository.DataObject;

namespace HumanResourcesModule.Business.Mapping;

public class CityProfile : Profile
{
    public CityProfile()
    {

        CreateMap<CitySelectListDataObject, CitySelectListDto>()
           .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Key))
           .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));

    }
}
