namespace EducationDepartment.Domain.Entity;

public class Faculty(int facultyId, string nameFaculty, string registrationNumber)
{
    public int FacultyId { get; set; } = facultyId;
    public string NameFaculty { get; set; } = nameFaculty;
    public string RegistrationNumber { get; set; } = registrationNumber;
}
