using HumanResourcesModule.Repository.DataObject;

namespace HumanResourcesModule.Repository.EntityFramework;

public interface ICityRepository
{

    CitySelectListDataObject GetByID(int ID);

    List<CitySelectListDataObject> GetList();

}