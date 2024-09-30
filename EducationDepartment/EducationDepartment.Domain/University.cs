namespace EducationDepartment.Domain;

public class University(string registrationNumber, string nameUni, string adress, string propertyType,
    string buildingOwnership, string rectorFullName, string degree, string tittle)
{
    public string RegistrationNumber { get; set;} = registrationNumber;
    public string NameUni { get; set;} = nameUni;
    public string Adress { get; set;} = adress;
    public string PropertyType { get; set;} = propertyType;
    public string BuildingOwnership { get; set;} = buildingOwnership;
    public string RectorFullName { get; set;} = rectorFullName;
    public string Degree { get; set;} = degree;
    public string Tittle { get; set;} = tittle;
}
