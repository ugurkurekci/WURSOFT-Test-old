using AutoMapper;
using HumanResourcesModule.Entity.Model;
using HumanResourcesModule.Repository.DataObject;

namespace HumanResourcesModule.Repository.Mapping;

public class CityProfile : Profile
{

    public CityProfile()
    {

        CreateMap<City, CitySelectListDataObject>()
           .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
           .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Name));

    }

}