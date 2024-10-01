namespace EducationDepartment.Domain;

public class Specialty(string specialtyId, string nameSpecialty, int numberOfGroups)
{
    public string SpecialtyId { get; set; } = specialtyId;
    public string NameSpecialty { get; set; } = nameSpecialty;
    public int NumberOfGroups { get; set; } = numberOfGroups;
}
