namespace EducationDepartment.Domain;

public class Faculty(int FacultyID, string Name, string RegistrationNumber)
{
    public int FacultyID { get; set; } = FacultyID;
    public string Name { get; set; } = Name;
    public string RegistrationNumber { get;  set; } = RegistrationNumber;
}
