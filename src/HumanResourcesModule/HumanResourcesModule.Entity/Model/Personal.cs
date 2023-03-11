namespace HumanResourcesModule.Entity.Model;

public class Personal : BaseEntity
{

    public int AdresID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Title { get; set; }

    public string Department { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Gender { get; set; }

    public string MaritalStatus { get; set; }

    public string DrivingLicence { get; set; }

    public string MilitaryStatus { get; set; }

    public string Notes { get; set; }

    public DateTime DateOfBirth { get; set; }

}