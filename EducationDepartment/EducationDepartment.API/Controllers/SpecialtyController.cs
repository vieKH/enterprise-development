using Microsoft.AspNetCore.Mvc;
using EducationDepartment.API.Services;
using EducationDepartment.API.Dto;

namespace EducationDepartment.API.Controllers;

/// <summary>
/// Class for specialty's controller
/// </summary>
/// <param name="service">Specialty's service</param>
[Route("api/[controller]")]
[ApiController]
public class SpecialtyController(SpecialtyService service) : ControllerBase
{
    /// <summary>
    /// Return list of specialties
    /// </summary>
    /// <returns> List of specialties</returns>
    [HttpGet]
    public ActionResult<IEnumerable<SpecialtyDto>> Get()
    {
        return Ok(service.GetAll());
    }

    /// <summary>
    /// Return specialty's information by specialty's id
    /// </summary>
    /// <param name="SpecialtyId">Specialty's id</param>
    /// <returns>Specialty's information</returns>
    [HttpGet("{SpecialtyId}")]
    public ActionResult<SpecialtyDto> Get(string SpecialtyId)
    {
        var specialty = service.GetById(SpecialtyId);

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
    public ActionResult<SpecialtyDto> Post([FromBody] SpecialtyDto specialty)
    {
        service.Post(specialty);

        return Ok(specialty);
    }

    /// <summary>
    /// Correct specialty's information by specialty's id
    /// </summary>
    /// <param name="specialty"></param>
    /// <returns>Success or not</returns>
    [HttpPut]
    public ActionResult<SpecialtyDto> Put([FromBody] SpecialtyDto specialty)
    {
        if (!service.Put(specialty))
            return NotFound();

        return Ok(specialty);
    }

    /// <summary>
    /// Delete specialty by specialty's id
    /// </summary>
    /// <param name="SpecialtyId">Specialty's id</param>
    /// <returns>Success or not</returns>
    [HttpDelete("{SpecialtyId}")]
    public IActionResult<string> Delete(string SpecialtyId)
    {
        if (!service.Delete(SpecialtyId))
            return NotFound();

        return Ok("Specialty was deleted");
    }
}
