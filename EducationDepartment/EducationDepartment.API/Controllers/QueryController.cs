using EducationDepartment.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace EducationDepartment.API.Controllers;

/// <summary>
/// Class for Query's controller
/// </summary>
/// <param name="service">Query's service</param>
[Route("api/[controller]")]
[ApiController]
public class QueryController(QueryService service) : ControllerBase
{
    /// <summary>
    /// Show university's information with registration number
    /// </summary>
    /// <param name="registrationNumber">Registration number</param>
    /// <returns>University's information with registration number</returns>
    [HttpGet("UniversityInformationWithRegistrationNumber:{number}")]
    public IActionResult InfoUniversityByRegistration(string registrationNumber)
    {
        return Ok(service.InfoUniversityByRegistration(registrationNumber));
    }

    /// <summary>
    /// Count total departments in every university
    /// </summary>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("Total departments in every university")]
    public IActionResult TotalDepartmentsInUniversity()
    {
        return Ok(service.TotalDepartmentsInUniversity());
    }

    /// <summary>
    /// Find 5 specialties with the highest number of groups 
    /// </summary>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("TopFiveSpecialties")]
    public IActionResult TopFiveSpecialties()
    {
        return Ok(service.TopFiveSpecialties());
    }

    /// <summary>
    /// Count total of groups with property type
    /// </summary>
    /// <param name="propertyType">Property type</param>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("TotalGroupsByProperty:{propertyType}")]
    public IActionResult TotalGroupsByProperty(string propertyType)
    {
        return Ok(service.TotalGroupsByProperty(propertyType));
    }

    /// <summary>
    /// Show faculties and specialties available in university
    /// </summary>
    /// <param name="nameUniversity">University's name</param>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("Information about faculties specialties in {nameUniversity}")]
    public IActionResult InfoFacultiesSpecialties(string nameUniversity)
    {
        return Ok(service.InfoFacultiesSpecialties(nameUniversity));
    }

    /// <summary>
    /// Count total of departments, faculties and specialties by attributes property type and building owner
    /// </summary>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("Total departments faculties specialties by property and building owner")]
    public IActionResult TotalDepartmentsFacultiesSpecialtiesByPropertyBuilding()
    {
        return Ok(service.TotalDepartmentsFacultiesSpecialtiesByPropertyBuilding());
    }
}
