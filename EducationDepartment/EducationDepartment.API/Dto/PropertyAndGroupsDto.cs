namespace EducationDepartment.API.Dto;

public class PropertyAndGroupsDto
{
    public required string RegistrationNumber { get; set; } 
    public required string NameUniversity { get; set; } 
    public required string PropertyType { get; set; }
    public required int TotalGroups { get; set; } 
}
