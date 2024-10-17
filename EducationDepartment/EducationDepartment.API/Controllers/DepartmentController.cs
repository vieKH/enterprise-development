using Microsoft.AspNetCore.Mvc;
using EducationDepartment.API.Dto;
using EducationDepartment.API.Services;

namespace EducationDepartment.API.Controllers;

/// <summary>
/// Class for department's controller
/// </summary>
/// <param name="service">Department's service</param>
[Route("api/[controller]")]
[ApiController]
public class DepartmentController(DepartmentService service) : ControllerBase
{
    /// <summary>
    /// Get list of departments
    /// </summary>
    /// <returns> List of departments</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Find department with departmentId
    /// </summary>
    /// <param name="departmentId">Department's id</param>
    /// <returns>Department's information</returns>
    [HttpGet("{departmentId}")]
    public IActionResult Get(string departmentId)
    {
        var department = service.GetById(departmentId);

        if (department == null)
            return NotFound();

        return Ok(department);
    }

    /// <summary>
    /// Add department to database
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
    /// Correct department's informations
    /// </summary>
    /// <param name="department">Department's information</param>
    /// <returns>Success or not</returns>
    [HttpPut]
    public IActionResult Put([FromBody] DepartmentDto department)
    {
        if (!service.Put(department))
            return NotFound();

        return Ok();
    }

    /// <summary>
    /// Delete department's information by department's id
    /// </summary>
    /// <param name="departmentId">Department's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{departmentId}")]
    public IActionResult Delete(string departmentId)
    {
        if (!service.Delete(departmentId))
            return NotFound();

        return Ok();
    }
}
