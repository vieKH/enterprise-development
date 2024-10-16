namespace EducationDepartment.Domain.Entity;

public class University(string registrationNumber, string nameUniversity, string address, string propertyType,
    string buildingOwnership, string rectorFullName, string degree, string tittle)
{
    public required string RegistrationNumber { get; set; } = registrationNumber;
    public required string NameUniversity { get; set; } = nameUniversity;
    public required string Address { get; set; } = address;
    public required string PropertyType { get; set; } = propertyType;
    public required string BuildingOwnership { get; set; } = buildingOwnership;
    public required string RectorFullName { get; set; } = rectorFullName;
    public required string Degree { get; set; } = degree;
    public required string Tittle { get; set; } = tittle;
}
