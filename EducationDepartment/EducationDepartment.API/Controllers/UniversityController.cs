using Microsoft.AspNetCore.Mvc;
using EducationDepartment.Domain.Entity;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Repositories;
using EducationDepartment.API.Services;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UniversityController(UniversityService service) : ControllerBase
{
    /// <summary>
    /// Return list of universities
    /// </summary>
    /// <returns> List of universities</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Return university's information by id
    /// </summary>
    /// <param name="id">University's registration number</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var university = service.GetById(id);

        if (university == null)
            return NotFound();

        return Ok(university);
    }

    /// <summary>
    /// Post university's information to database
    /// </summary>
    /// <param name="university">University's information</param>
    /// <returns>Success or not</returns>
    [HttpPost]
    public IActionResult Post([FromBody] UniversityDto university)
    {
        service.Post(university);

        return Ok();
    }

    /// <summary>
    /// Correct university's information by id
    /// </summary>
    /// <param name="id">University's registration number</param>
    /// <param name="university">University's information</param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] UniversityDto value)
    {
        if (!service.Put(id, value))
            return NotFound();

        return Ok();

    }

    /// <summary>
    /// Delete university's information by id
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
