namespace EducationDepartment.Domain;

public class Department(int facultyId, string nameDepartment, string departmentId)
{
    public int FacultyId { get; set; } = facultyId;
    public string NameDepartment { get; set; } = nameDepartment;
    public string DepartmentId { get; set; } = departmentId;
}
