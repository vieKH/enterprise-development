namespace EducationDepartment.Domain;

public class Specialty(string specialtyId, string nameSpecialty, int numberOfGroups)
{
    public required string SpecialtyId { get; set; } = specialtyId;
    public required string NameSpecialty { get; set; } = nameSpecialty;
    public int NumberOfGroups { get; set; } = numberOfGroups;
}
