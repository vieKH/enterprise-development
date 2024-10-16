namespace EducationDepartment.Domain.Entity;

public class Faculty(int facultyId, string nameFaculty, string registrationNumber)
{
    public int FacultyId { get; set; } = facultyId;
    public required string NameFaculty { get; set; } = nameFaculty;
    public required string RegistrationNumber { get; set; } = registrationNumber;
}
