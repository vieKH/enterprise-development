namespace EducationDepartment.Domain;

public class University(string RegistrationNumber, string Name, string Adress, string PropertyType,
    string BuildingOwership, string RectorFullName, string Degree, string Tittle)
{
    public string RegistrationNumber { get; set;} = RegistrationNumber;
    public string Name { get; set;} = Name;
    public string Adress { get; set;} = Adress;
    public string PropertyType { get; set;} = PropertyType;
    public string BuildingOwership { get; set;} = BuildingOwership;
    public string RectorFullName { get; set;} = RectorFullName;
    public string Degree { get; set;} = Degree;
    public string Tittle { get; set;} = Tittle;
}
