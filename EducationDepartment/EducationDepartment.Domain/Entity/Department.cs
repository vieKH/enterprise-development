namespace EducationDepartment.Domain.Entity;

public class Department(int facultyId, string nameDepartment, string departmentId)
{
    public int FacultyId { get; set; } = facultyId;
    public required string NameDepartment { get; set; } = nameDepartment;
    public required string DepartmentId { get; set; } = departmentId;
}
