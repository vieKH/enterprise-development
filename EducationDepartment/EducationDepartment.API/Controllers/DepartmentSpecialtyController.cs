﻿using Microsoft.AspNetCore.Mvc;
using EducationDepartment.API.Services;
using EducationDepartment.API.Dto;

namespace EducationDepartment.API.Controllers;

/// <summary>
/// Class for (department specialty)'s controller
/// </summary>
/// <param name="service">(department specialty)'s service</param>
[Route("api/[controller]")]
[ApiController]
public class DepartmentSpecialtyController(DepartmentSpecialtyService service) : ControllerBase
{
    /// <summary>
    /// Return list of (department specialty)
    /// </summary>
    /// <returns> List of (department specialty)</returns>
    [HttpGet]
    public ActionResult<DepartmentSpecialtyDto> Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Find (department specialty)'s information by specialty's id
    /// </summary>
    /// <param name="specialtyId">Specialty's id</param>
    /// <returns>(department specialty)'s information</returns>
    [HttpGet("{specialtyId}")]
    public ActionResult<DepartmentSpecialtyDto> Get(string specialtyId)
    {
        var departmentSpecialty = service.GetById(specialtyId);

        if (departmentSpecialty == null)
            return NotFound();

        return Ok(departmentSpecialty);
    }

    /// <summary>
    /// Post (Department specialty) to database
    /// </summary>
    /// <param name="departmentSpecialty">(Department specialty)'s information in format DTO</param>
    /// <returns>Success or not</returns>
    [HttpPost]
    public ActionResult<DepartmentSpecialtyDto> Post([FromBody] DepartmentSpecialtyDto departmentSpecialty)
    {
        service.Post(departmentSpecialty);

        return Ok();
    }

    /// <summary>
    /// Correct (department specialty)'s information by specialty's id
    /// </summary>
    /// <param name="departmentSpecialty">(Department specialty)'s information</param>
    /// <returns>Success or not</returns>
    [HttpPut]
    public ActionResult<DepartmentSpecialtyDto> Put([FromBody] DepartmentSpecialtyDto departmentSpecialty)
    {
        if (!service.Put(departmentSpecialty))
            return NotFound();

        return Ok();
    }

    /// <summary>
    /// Delete (department specialty) by specialty's id
    /// </summary>
    /// <param name="specialtyId">Specialty's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{specialtyId}")]
    public ActionResult<DepartmentSpecialtyDto> Delete(string specialtyId)
    {
        if (!service.Delete(specialtyId))
            return NotFound();

        return Ok();
    }
}
