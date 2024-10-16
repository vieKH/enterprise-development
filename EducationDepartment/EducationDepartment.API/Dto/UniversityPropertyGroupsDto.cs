namespace EducationDepartment.API.Dto;

public class UniversityPropertyGroupsDto
{
    public required string RegistrationNumber { get; set; }
    public required string NameUniversity {  get; set; }
    public required string PropertyType { get; set; }
    public int TotalGroups { get; set; }
}
