
namespace EducationDepartment.Domain;

public class Department(int FacultyID, string NameDep, string DepartmentID)
{
    public int FacultyID { get; set; } = FacultyID;
    public string NameDep { get; set;} = NameDep;
    public string DepartmentID { get; set; } = DepartmentID;
}
