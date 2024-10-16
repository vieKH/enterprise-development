using Microsoft.AspNetCore.Mvc;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repository;
using EducationDepartment.API.Dto;
using AutoMapper;

namespace EducationDepartment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController(IRepository repository, IMapper mapper) : ControllerBase
{
    /// <summary>
    /// Return list of departments
    /// </summary>
    /// <returns> List of departments</returns>
    [HttpGet]
    public IEnumerable<Department> Get()
    {
        return repository.GetDepartments();
    }

    /// <summary>
    /// Return department's information by id
    /// </summary>
    /// <param name="id">Department's id</param>
    /// <returns>Success or not</returns>
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var department = repository.GetDepartment(id);

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
    public IActionResult Post([FromBody] DepartmentDto value)
    {
        var department = mapper.Map<Department>(value); 

        repository.PostDepartment(department);

        return Ok();
    }

    /// <summary>
    /// Correct department's information by id
    /// </summary>
    /// <param name="id">Department's id</param>
    /// <param name="department">Department's information</param>
    /// <returns>Success or not</returns>
    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] Department department)
    {
        if (!repository.PutDepartment(id, department))
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
        if (!repository.DeleteDepartment(id))
            return NotFound();

        return Ok();
    }
}
