using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain;

namespace EducationDepartment.API.Dto;

public class DepartmentSpecialtyDto
{
    public required string DepartmentId { get; set; }
    public required string SpecialtyId { get; set; }
}
