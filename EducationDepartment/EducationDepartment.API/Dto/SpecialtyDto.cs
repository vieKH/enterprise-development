using EducationDepartment.Domain;

namespace EducationDepartment.API.Dto;

public class SpecialtyDto
{
    public required string SpecialtyId { get; set; }
    public required string NameSpecialty { get; set; }
    public int NumberOfGroups { get; set; }
}
