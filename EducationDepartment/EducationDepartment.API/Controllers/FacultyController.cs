using Microsoft.AspNetCore.Mvc;
using EducationDepartment.API.Services;
using EducationDepartment.API.Dto;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FacultyController(FacultyService service) : ControllerBase
{
    /// <summary>
    /// Return list of faculties
    /// </summary>
    /// <returns> List of faculties</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Return faculty's information by id
    /// </summary>
    /// <param name="id">Faculty's id</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var faculty = service.GetById(id);

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
    /// Correct faculty's information by id
    /// </summary>
    /// <param name="id">Faculty's id</param>
    /// <param name="faculty">Faculty's information</param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] FacultyDto faculty)
    {
        if (!service.Put(id, faculty))
            return NotFound();

        return Ok();

    }

    /// <summary>
    /// Delete faculty by id
    /// </summary>
    /// <param name="id">Faculty's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        if (!service.Delete(id))
            return NotFound();

        return Ok();
    }
}
