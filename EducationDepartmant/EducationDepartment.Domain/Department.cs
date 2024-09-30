namespace EducationDepartment.Domain;

public class Department(int facultyId, string nameDep, string departmentId)
{
    public int FacultyId { get; set; } = facultyId;
    public string NameDep { get; set;} = nameDep;
    public string DepartmentID { get; set; } = departmentId;
}
