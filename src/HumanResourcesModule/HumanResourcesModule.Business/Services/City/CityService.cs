using AutoMapper;
using HumanResourcesModule.Business.Dto;
using HumanResourcesModule.Repository.DataObject;
using HumanResourcesModule.Repository.EntityFramework;

namespace HumanResourcesModule.Business.Services.City;

public class CityService : ICityService
{

    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;

    public CityService(ICityRepository cityRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }

    public CitySelectListDto GetByID(int ID)
    {
        CitySelectListDataObject citySelectListDataObject = _cityRepository.GetByID(ID);
        return _mapper.Map<CitySelectListDto>(citySelectListDataObject);
    }

    public List<CitySelectListDto> GetList()
    {
        List<CitySelectListDataObject> citySelectListDataObjects = _cityRepository.GetList();
        return _mapper.Map<List<CitySelectListDto>>(citySelectListDataObjects);
    }
}