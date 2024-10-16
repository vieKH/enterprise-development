namespace EducationDepartment.API.Dto;

public class SpecialtiesFacultiesDepartmentsForPropertyBuilding
{
    public required string PropertyType { get; set; }
    public required string BuildingOwnership { get; set; }
    public int TotalSpecialties { get; set; }
    public int TotalFaculties { get; set; }
    public int TotalDepartments { get; set; }
}
