namespace EducationDepartment.Domain;

public class Faculty(int facultyId, string nameFa, string registrationNumber)
{
    public int FacultyId { get; set; } = facultyId;
    public string NameFa { get; set; } = nameFa;
    public string RegistrationNumber { get;  set; } = registrationNumber;
}
