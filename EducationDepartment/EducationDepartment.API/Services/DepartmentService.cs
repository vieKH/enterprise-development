using AutoMapper;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repositories;

namespace EducationDepartment.API.Services;

public class DepartmentService(DepartmentRepository repository, IMapper mapper) : IService<DepartmentDto>
{
    public bool Delete(string id) => repository.Delete(id);

    public IEnumerable<DepartmentDto> GetAll() => repository.GetAll().Select(mapper.Map<DepartmentDto>);

    public DepartmentDto? GetById(string id) => mapper.Map<DepartmentDto>(repository.GetById(id));

    public void Post(DepartmentDto dtoData) 
    {
        repository.Post(mapper.Map<Department>(dtoData));
    }
    
    public bool Put(string id, DepartmentDto dtoData) => repository.Put(id, mapper.Map<Department>(dtoData));
}
