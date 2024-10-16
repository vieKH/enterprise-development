using Microsoft.AspNetCore.Mvc;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repository;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FacultyController(IRepository repository) : ControllerBase
{
    /// <summary>
    /// Return list of faculties
    /// </summary>
    /// <returns> List of faculties</returns>
    [HttpGet]
    public IEnumerable<Faculty> Get()
    {
        return repository.GetFaculties();
    }

    /// <summary>
    /// Return faculty's information by id
    /// </summary>
    /// <param name="id">Faculty's id</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var faculty = repository.GetFaculty(id);

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
    public IActionResult Post([FromBody] Faculty faculty)
    {
        repository.PostFaculty(faculty);

        return Ok();
    }

    /// <summary>
    /// Correct faculty's information by id
    /// </summary>
    /// <param name="id">Faculty's id</param>
    /// <param name="faculty">Faculty's information</param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Faculty faculty)
    {
        if (!repository.PutFaculty(id, faculty))
            return NotFound();

        return Ok();

    }

    /// <summary>
    /// Delete faculty by id
    /// </summary>
    /// <param name="id">Faculty's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (!repository.DeleteFaculty(id))
            return NotFound();

        return Ok();
    }
}
