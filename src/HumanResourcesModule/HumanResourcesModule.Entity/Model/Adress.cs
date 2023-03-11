namespace HumanResourcesModule.Entity.Model;

public class Adress : BaseEntity
{

    public int CityID { get; set; }

    public string StreetAddress { get; set; }

    public string PostaCode { get; set; }

}