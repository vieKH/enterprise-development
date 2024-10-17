using Microsoft.AspNetCore.Mvc;
using EducationDepartment.API.Services;
using EducationDepartment.API.Dto;

namespace EducationDepartment.API.Controllers;

/// <summary>
/// Class for Faculty's controller
/// </summary>
/// <param name="service">Faculty's service</param>
[Route("api/[controller]")]
[ApiController]
public class FacultyController(FacultyService service) : ControllerBase
{
    /// <summary>
    /// Get list of faculties
    /// </summary>
    /// <returns>List of faculties</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Find faculty's information by faculty's id
    /// </summary>
    /// <param name="facultyId">Faculty's id</param>
    /// <returns>Faculty's information</returns>
    [HttpGet("{facultyId}")]
    public IActionResult Get(string facultyId)
    {
        var faculty = service.GetById(facultyId);

        if (faculty == null)
            return NotFound();

        return Ok(faculty);
    }

    /// <summary>
    /// Post faculty's information to database
    /// </summary>
    /// <param name="faculty">Faculty's information</param>
    /// <returns>Success or not</returns>
    [HttpPost]
    public IActionResult Post([FromBody] FacultyDto faculty)
    {
        service.Post(faculty);

        return Ok();
    }

    /// <summary>
    /// Correct faculty's information by faculty's id
    /// </summary>
    /// <param name="faculty">Faculty's information</param>
    /// <returns>Success or not</returns>
    [HttpPut]
    public IActionResult Put([FromBody] FacultyDto faculty)
    {
        if (!service.Put(faculty))
            return NotFound();

        return Ok();
    }

    /// <summary>
    /// Delete faculty by faculty's id
    /// </summary>
    /// <param name="facultyId">Faculty's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{facultyId}")]
    public IActionResult Delete(string facultyId)
    {
        if (!service.Delete(facultyId))
            return NotFound();

        return Ok();
    }
}
