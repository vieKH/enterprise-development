using Microsoft.AspNetCore.Mvc;
using EducationDepartment.API.Services;
using EducationDepartment.API.Dto;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentSpecialtyController(DepartmentSpecialtyService service) : ControllerBase
{
    /// <summary>
    /// Return list of (department specialty)
    /// </summary>
    /// <returns> List of (department specialty)</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Return (department specialty)'s information by id
    /// </summary>
    /// <param name="id">(Department specialty)'s id</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var departmentSpecialty = service.GetById(id);

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
    public IActionResult Post([FromBody] DepartmentSpecialtyDto departmentSpecialty)
    {
        service.Post(departmentSpecialty);

        return Ok();
    }

    /// <summary>
    /// Correct (department specialty)'s information by id
    /// </summary>
    /// <param name="id">(Department specialty)'s id</param>
    /// <param name="departmentSpecialty">(Department specialty)'s information</param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] DepartmentSpecialtyDto departmentSpecialty)
    {
        if (!service.Put(id, departmentSpecialty))
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
        if (!service.Delete(id))
            return NotFound();

        return Ok();
    }
}
