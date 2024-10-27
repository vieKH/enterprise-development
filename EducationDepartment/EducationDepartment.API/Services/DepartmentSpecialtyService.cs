﻿using AutoMapper;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repositories;

namespace EducationDepartment.API.Services;

/// <summary>
/// Class for (department specialty)'s service
/// </summary>
/// <param name="repository">(department specialty)'s repository</param>
/// <param name="mapper">Automapper's object for mapping 2 objects DepartmentSpecialty and DepartmentSpecialtyDto</param>
public class DepartmentSpecialtyService(DepartmentSpecialtyRepository repository, IMapper mapper): IService<DepartmentSpecialtyDto>
{
    /// <summary>
    /// Method delete (department specialty) by specialty's id
    /// </summary>
    /// <param name="id">Specialty's id</param>
    /// <returns>True or False</returns>
    public bool Delete(string id) => repository.Delete(id);

    /// <summary>
    /// Method get list of (department specialty)
    /// </summary>
    /// <returns>List of departments</returns>
    public IEnumerable<DepartmentSpecialtyDto> GetAll() => repository.GetAll().Select(mapper.Map<DepartmentSpecialtyDto>);

    /// <summary>
    /// Method get (department specialty) by specialty's id
    /// </summary>
    /// <param name="id">Specialty's id</param>
    /// <returns>(department specialty)'s information or null</returns>
    public DepartmentSpecialtyDto? GetById(string id) => mapper.Map<DepartmentSpecialtyDto>(repository.GetById(id));

    /// <summary>
    /// Method post (department specialty) to database
    /// </summary>
    /// <param name="dtoData">Department's information</param>
    public void Post(DepartmentSpecialtyDto dtoData)
    {
        repository.Post(mapper.Map<DepartmentSpecialty>(dtoData));
    }

    /// <summary>
    /// Method put (department specialty) by speciatly's id
    /// </summary>
    /// <param name="dtoData">(department specialty)'s information</param>
    /// <returns>True or False</returns>
    public bool Put(DepartmentSpecialtyDto dtoData) => repository.Put(mapper.Map<DepartmentSpecialty>(dtoData));
}
