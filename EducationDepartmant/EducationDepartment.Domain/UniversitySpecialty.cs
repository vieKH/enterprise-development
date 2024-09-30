namespace EducationDepartment.Domain;

public class UniversitySpecialty(string RegistrationNumber, int SpecialtyID, int NumberOfGroups)
{
    public string RegistrationNumber { get; set;} = RegistrationNumber;
    public int SpecialtyID { get; set;} = SpecialtyID;
    public int NumberOfGroups { get; set;} = NumberOfGroups;
}
