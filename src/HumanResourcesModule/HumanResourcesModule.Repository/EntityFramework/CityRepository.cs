using AutoMapper;
using HumanResourcesModule.Entity.DataAccess;
using HumanResourcesModule.Entity.Model;
using HumanResourcesModule.Repository.DataObject;

namespace HumanResourcesModule.Repository.EntityFramework;

public class CityRepository : ICityRepository
{

    private readonly HumanResourcesDataContext _humanResourcesDataContext;
    private readonly IMapper _mapper;

    public CityRepository(HumanResourcesDataContext humanResourcesDataContext, IMapper mapper)
    {
        _humanResourcesDataContext = humanResourcesDataContext;
        _mapper = mapper;
    }

    public CitySelectListDataObject GetByID(int ID)
    {
        City city = _humanResourcesDataContext.City.SingleOrDefault(x => x.ID == ID);
        return _mapper.Map<CitySelectListDataObject>(city);
    }

    public List<CitySelectListDataObject> GetList()
    {
        List<City> cities = _humanResourcesDataContext.City.ToList();
        return _mapper.Map<List<CitySelectListDataObject>>(cities);
    }

}