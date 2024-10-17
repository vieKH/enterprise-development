using AutoMapper;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repositories;

namespace EducationDepartment.API.Services;

public class DepartmentSpecialtyService(DeparmentSpecialtyRepository repository, IMapper mapper): IService<DepartmentSpecialtyDto>
{
    public bool Delete(string id) => repository.Delete(id);

    public IEnumerable<DepartmentSpecialtyDto> GetAll() => repository.GetAll().Select(mapper.Map<DepartmentSpecialtyDto>);

    public DepartmentSpecialtyDto? GetById(string id) => mapper.Map<DepartmentSpecialtyDto>(repository.GetById(id));

    public void Post(DepartmentSpecialtyDto dtoData)
    {
        repository.Post(mapper.Map<DepartmentSpecialty>(dtoData));
    }

    public bool Put(string id, DepartmentSpecialtyDto dtoData) => repository.Put(id, mapper.Map<DepartmentSpecialty>(dtoData));
}
