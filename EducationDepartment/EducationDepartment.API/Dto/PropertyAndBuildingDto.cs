namespace EducationDepartment.API.Dto;

public class PropertyAndBuildingDto
{
    public required string PropertyType { get; set; } 

    public required string BuildingOwnership { get; set; } 

    public required int TotalSpecialties { get; set; }

    public required int TotalFaculties { get; set; }

    public required int TotalDepartments { get; set; }
}
