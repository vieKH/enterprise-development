namespace EducationDepartment.Domain;

public class UniversitySpecialty(string RegistrationNumber, string SpecialtyID, int NumberOfGroups)
{
    public string RegistrationNumber { get; set;} = RegistrationNumber;
    public string SpecialtyID { get; set;} = SpecialtyID;
    public int NumberOfGroups { get; set;} = NumberOfGroups;
}
