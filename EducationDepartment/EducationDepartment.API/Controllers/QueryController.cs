using EducationDepartment.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QueryController(QueryService service) : ControllerBase
{ 
    [HttpGet("University's information with registration number:{registrationNumber}")]
    public IActionResult InfoUniversityByRegistration(string registrationNumber)
    {
        return Ok(service.InfoUniversityByRegistration(registrationNumber));
    }

    [HttpGet("Total departments in every university")]
    public IActionResult TotalDepartmentsInUniversity()
    {
        return Ok(service.TotalDepartmentsInUniversity());
    }

    [HttpGet("Top five specialties")]
    public IActionResult TopFiveSpecialties()
    {
        return Ok(service.TopFiveSpecialties());
    }

    [HttpGet("Total groups by property:{propertyType}")]
    public IActionResult TotalGroupsByProperty(string propertyType)
    {
        return Ok(service.TotalGroupsByProperty(propertyType));
    }

    [HttpGet("Information about faculties specialties in {nameUniversity}")]
    public IActionResult InfoFacultiesSpecialties(string nameUniversity)
    {
        return Ok(service.InfoFacultiesSpecialties(nameUniversity));
    }

    [HttpGet("Total departments faculties specialties by property and building owner")]
    public IActionResult TotalDepartmentsFacultiesSpecialtiesByPropertyBuilding()
    {
        return Ok(service.TotalDepartmentsFacultiesSpecialtiesByPropertyBuilding());
    }
}
