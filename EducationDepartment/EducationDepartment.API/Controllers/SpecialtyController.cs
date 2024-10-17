using Microsoft.AspNetCore.Mvc;
using EducationDepartment.API.Services;
using EducationDepartment.API.Dto;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpecialtyController(SpecialtyService service) : ControllerBase
{
    /// <summary>
    /// Return list of specialties
    /// </summary>
    /// <returns> List of specialties</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Return specialty's information by id
    /// </summary>
    /// <param name="id">Specialty's id</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var specialty = service.GetById(id);

        if (specialty == null)
            return NotFound();

        return Ok(specialty);
    }

    /// <summary>
    /// Post specialty's information to database
    /// </summary>
    /// <param name="specialty">Specialty's information</param>
    /// <returns>Success or not</returns>
    [HttpPost]
    public IActionResult Post([FromBody] SpecialtyDto specialty)
    {
        service.Post(specialty);

        return Ok();
    }

    /// <summary>
    /// Correct specialty's information by id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="specialty"></param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] SpecialtyDto specialty)
    {
        if (!service.Put(id, specialty))
            return NotFound();

        return Ok();

    }

    /// <summary>
    /// Delete specialty by id
    /// </summary>
    /// <param name="id">Specialty's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        if (!service.Delete(id))
            return NotFound();

        return Ok();
    }
}
