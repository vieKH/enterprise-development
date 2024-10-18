﻿using EducationDepartment.API.Dto;
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
    /// Return list op university's information with registration number
    /// </summary>
    /// <param name="registrationNumber">Registration number</param>
    /// <returns>University's information with registration number</returns>
    [HttpGet("Universities")]
    public ActionResult<UniversityDto> InfoUniversityByRegistration(string registrationNumber)
    {
        return Ok(service.InfoUniversityByRegistration(registrationNumber));
    }

    /// <summary>
    /// Count total departments in every university
    /// </summary>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("Departments")]
    public ActionResult<UniversityAndDepartmentsDto> TotalDepartmentsInUniversity()
    {
        return Ok(service.TotalDepartmentsInUniversity());
    }

    /// <summary>
    /// Find 5 specialties with the highest number of groups 
    /// </summary>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("Top5Specialties")]
    public ActionResult<SpecialtyAndGroupsDto> TopFiveSpecialties()
    {
        return Ok(service.TopFiveSpecialties());
    }

    /// <summary>
    /// Count total of groups with property type
    /// </summary>
    /// <param name="propertyType">Property type</param>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("Properties")]
    public ActionResult<PropertyAndGroupsDto> TotalGroupsByProperty(string propertyType)
    {
        return Ok(service.TotalGroupsByProperty(propertyType));
    }

    /// <summary>
    /// Return list of faculties and specialties available in university
    /// </summary>
    /// <param name="nameUniversity">University's name</param>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("FacultiesSpecialties")]
    public ActionResult<FacultyAndSpecialtyDto> InfoFacultiesSpecialties(string nameUniversity)
    {
        return Ok(service.InfoFacultiesSpecialties(nameUniversity));
    }

    /// <summary>
    /// Count total of departments, faculties and specialties by attributes property type and building owner
    /// </summary>
    /// <returns>List of objects mentioned in format json</returns>
    [HttpGet("PropertiesBuildings")]
    public ActionResult<PropertyAndBuildingDto> TotalDepartmentsFacultiesSpecialtiesByPropertyBuilding()
    {
        return Ok(service.TotalDepartmentsFacultiesSpecialtiesByPropertyBuilding());
    }
}
