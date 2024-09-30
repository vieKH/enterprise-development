namespace EducationDepartment.Domain;

public class Faculty(int FacultyID, string NameFa, string RegistrationNumber)
{
    public int FacultyID { get; set; } = FacultyID;
    public string NameFa { get; set; } = NameFa;
    public string RegistrationNumber { get;  set; } = RegistrationNumber;
}
