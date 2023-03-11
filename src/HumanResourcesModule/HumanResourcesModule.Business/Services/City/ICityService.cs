using HumanResourcesModule.Business.Dto;
using HumanResourcesModule.Repository.DataObject;

namespace HumanResourcesModule.Business.Services.City;

public interface ICityService
{

    CitySelectListDto GetByID(int ID);

    List<CitySelectListDto> GetList();

}