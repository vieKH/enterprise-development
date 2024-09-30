namespace EducationDepartment.Domain;

public class University(string RegistrationNumber, string NameUni, string Adress, string PropertyType,
    string BuildingOwnership, string RectorFullName, string Degree, string Tittle)
{
    public string RegistrationNumber { get; set;} = RegistrationNumber;
    public string NameUni { get; set;} = NameUni;
    public string Adress { get; set;} = Adress;
    public string PropertyType { get; set;} = PropertyType;
    public string BuildingOwnership { get; set;} = BuildingOwnership;
    public string RectorFullName { get; set;} = RectorFullName;
    public string Degree { get; set;} = Degree;
    public string Tittle { get; set;} = Tittle;
}
