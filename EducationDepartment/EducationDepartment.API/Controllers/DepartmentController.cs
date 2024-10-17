using Microsoft.AspNetCore.Mvc;
using EducationDepartment.Domain.Entity;
using EducationDepartment.API.Dto;
using AutoMapper;
using EducationDepartment.Domain.Repositories;
using EducationDepartment.API.Services;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController(DepartmentService service) : ControllerBase
{
    /// <summary>
    /// Return list of departments
    /// </summary>
    /// <returns> List of departments</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Return department's information by id
    /// </summary>
    /// <param name="id">Department's id</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var department = service.GetById(id);

        if (department == null)
            return NotFound();

        return Ok(department);
    }

    /// <summary>
    /// Post department's information to database
    /// </summary>
    /// <param name="department">Department's information</param>
    /// <returns>Success or not</returns>
    [HttpPost]
    public IActionResult Post([FromBody] DepartmentDto department)
    {
        service.Post(department);

        return Ok();
    }

    /// <summary>
    /// Correct department's information by id
    /// </summary>
    /// <param name="id">Department's id</param>
    /// <param name="department">Department's information</param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] DepartmentDto department)
    {
        if (!service.Put(id, department))
            return NotFound();

        return Ok();

    }

    /// <summary>
    /// Delete department's information by id
    /// </summary>
    /// <param name="id">Department's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        if (!service.Delete(id))
            return NotFound();

        return Ok();
    }
}
