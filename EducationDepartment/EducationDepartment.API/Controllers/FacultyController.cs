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
    /// Return list of faculties
    /// </summary>
    /// <returns>List of faculties</returns>
    [HttpGet]
    public ActionResult<IEnumerable<FacultyDto>> Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Find faculty's information by faculty's id
    /// </summary>
    /// <param name="facultyId">Faculty's id</param>
    /// <returns>Faculty's information</returns>
    [HttpGet("{facultyId}")]
    public ActionResult<FacultyDto> Get(string facultyId)
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
    public ActionResult<FacultyDto> Post([FromBody] FacultyDto faculty)
    {
        service.Post(faculty);

        return Ok(faculty);
    }

    /// <summary>
    /// Correct faculty's information by faculty's id
    /// </summary>
    /// <param name="faculty">Faculty's information</param>
    /// <returns>Success or not</returns>
    [HttpPut]
    public ActionResult<FacultyDto> Put([FromBody] FacultyDto faculty)
    {
        if (!service.Put(faculty))
            return NotFound();

        return Ok(faculty);
    }

    /// <summary>
    /// Delete faculty by faculty's id
    /// </summary>
    /// <param name="facultyId">Faculty's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{facultyId}")]
    public ActionResult<string> Delete(string facultyId)
    {
        if (!service.Delete(facultyId))
            return NotFound();

        return Ok("Faculty was deleted");
    }
}
