using Microsoft.AspNetCore.Mvc;
using EducationDepartment.API.Dto;
using EducationDepartment.API.Services;

namespace EducationDepartment.API.Controllers;

/// <summary>
/// Class for university's controller
/// </summary>
/// <param name="service"></param>
[Route("api/[controller]")]
[ApiController]
public class UniversityController(UniversityService service) : ControllerBase
{
    /// <summary>
    /// Return list of universities
    /// </summary>
    /// <returns> List of universities</returns>
    [HttpGet]
    public ActionResult<UniversityDto> Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Return university's information by registration number
    /// </summary>
    /// <param name="registrationNumber">University's registration number</param>
    /// <returns>University's information</returns>
    [HttpGet("{registrationNumber}")]
    public ActionResult<UniversityDto> Get(string registrationNumber)
    {
        var university = service.GetById(registrationNumber);

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
    public ActionResult<UniversityDto> Post([FromBody] UniversityDto university)
    {
        service.Post(university);

        return Ok();
    }

    /// <summary>
    /// Correct university's information by id
    /// </summary>
    /// <param name="university">University's information</param>
    /// <returns>Success or not</returns>
    [HttpPut]
    public ActionResult<UniversityDto> Put([FromBody] UniversityDto university)
    {
        if (!service.Put(university))
            return NotFound();

        return Ok();
    }

    /// <summary>
    /// Delete university's information by registration number
    /// </summary>
    /// <param name="registrationNumber">Registration number</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{registrationNumber}")]
    public ActionResult<UniversityDto> Delete(string registrationNumber)
    {
        if (!service.Delete(registrationNumber))
            return NotFound();

        return Ok();
    }
}
