namespace EducationDepartment.Domain;

public class Specitalty(string SpecialtyID, string NameSp, int NumberOfGroups)
{
    public string SpecialtyID { get; set; } = SpecialtyID;
    public string NameSp { get; set; } = NameSp;
    public int NumberOfGroups { get; set; } = NumberOfGroups; 
}
