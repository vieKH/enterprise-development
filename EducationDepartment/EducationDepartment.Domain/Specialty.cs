namespace EducationDepartment.Domain;

public class Specitalty(string specialtyId, string nameSp, int numberOfGroups)
{
    public string SpecialtyId { get; set; } = specialtyId;
    public string NameSp { get; set; } = nameSp;
    public int NumberOfGroups { get; set; } = numberOfGroups;
}
