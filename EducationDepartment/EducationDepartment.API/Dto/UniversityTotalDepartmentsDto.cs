namespace EducationDepartment.API.Dto;

public class UniversityTotalDepartmentsDto
{
    public required string NameUniversity { get; set; }
    public required string RegistrationNumber { get; set; } 
    public int TotalDepartments { get; set; }
}
