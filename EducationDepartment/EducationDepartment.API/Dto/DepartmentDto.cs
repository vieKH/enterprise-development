using EducationDepartment.Domain.Entity;

namespace EducationDepartment.API.Dto;

public class DepartmentDto
{
    public int FacultyId { get; set; }
    public required string NameDepartment { get; set; }
    public required string DepartmentId { get; set; }
}
