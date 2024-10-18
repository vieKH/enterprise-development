namespace EducationDepartment.API.Dto;

/// <summary>
/// Class for data transfer about total departments in every university
/// </summary>
public class UniversityAndDepartmentsDto
{
    /// <summary>
    /// University's name
    /// </summary>
    public required string NameUniversity { get; set; }

    /// <summary>
    /// University's registration number
    /// </summary>
    public required string RegistrationNumber { get; set; }

    /// <summary>
    /// Total departents
    /// </summary>
    public required int TotalDepartments { get; set; }
}

