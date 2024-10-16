using Microsoft.AspNetCore.Mvc;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repository;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentSpecialtyController(IRepository repository) : ControllerBase
{
    /// <summary>
    /// Return list of (department specialty)
    /// </summary>
    /// <returns> List of (department specialty)</returns>
    [HttpGet]
    public IEnumerable<DepartmentSpecialty> Get()
    {
        return repository.GetDepartmentSpecialties();
    }

    /// <summary>
    /// Return (department specialty)'s information by id
    /// </summary>
    /// <param name="id">(Department specialty)'s id</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var departmentSpecialty = repository.GetDepartmentSpecialty(id);

        if (departmentSpecialty == null)
            return NotFound();

        return Ok(departmentSpecialty);
    }

    /// <summary>
    /// Post (Department specialty) to database
    /// </summary>
    /// <param name="departmentSpecialty">(Department specialty)'s information</param>
    /// <returns>Success or not</returns>
    [HttpPost]
    public IActionResult Post([FromBody] DepartmentSpecialty departmentSpecialty)
    {
        repository.PostDepartmentSpecialty(departmentSpecialty);

        return Ok();
    }

    /// <summary>
    /// Correct (department specialty)'s information by id
    /// </summary>
    /// <param name="id">(Department specialty)'s id</param>
    /// <param name="departmentSpecialty">(Department specialty)'s information</param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] DepartmentSpecialty departmentSpecialty)
    {
        if (!repository.PutDepartmentSpecialty(id, departmentSpecialty))
            return NotFound();

        return Ok();

    }

    /// <summary>
    /// Delete (department specialty) by id
    /// </summary>
    /// <param name="id">(Department specialty)'s id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        if (!repository.DeleteDepartmentSpecialty(id))
            return NotFound();

        return Ok();
    }
}
