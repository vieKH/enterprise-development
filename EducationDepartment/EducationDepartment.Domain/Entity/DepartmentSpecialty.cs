namespace EducationDepartment.Domain.Entity;

public class DepartmentSpecialty(string departmentId, string specialtyId)
{
    public required string DepartmentId { get; set; } = departmentId;
    public required string SpecialtyId { get; set; } = specialtyId;
}

