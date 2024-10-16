using Microsoft.AspNetCore.Mvc;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repository;
using EducationDepartment.Domain;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpecialtyController(IRepository repository) : ControllerBase
{
    /// <summary>
    /// Return list of specialties
    /// </summary>
    /// <returns> List of specialties</returns>
    [HttpGet]
    public IEnumerable<Specialty> Get()
    {
        return repository.GetSpecialties();
    }

    /// <summary>
    /// Return specialty's information by id
    /// </summary>
    /// <param name="id">Specialty's id</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var specialty = repository.GetSpecialty(id);

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
    public IActionResult Post([FromBody] Specialty specialty)
    {
        repository.PostSpecialty(specialty);

        return Ok();
    }

    /// <summary>
    /// Correct specialty's information by id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="specialty"></param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] Specialty specialty)
    {
        if (!repository.PutSpecialty(id, specialty))
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
        if (!repository.DeleteSpecialty(id))
            return NotFound();

        return Ok();
    }
}
