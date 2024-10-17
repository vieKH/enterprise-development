using AutoMapper;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repositories;

namespace EducationDepartment.API.Services;

public class SpecialtyService(SpecialtyRepository repository, IMapper mapper) : IService<SpecialtyDto>
{
    public bool Delete(string id) => repository.Delete(id);

    public IEnumerable<SpecialtyDto> GetAll() => repository.GetAll().Select(mapper.Map<SpecialtyDto>);

    public SpecialtyDto? GetById(string id) => mapper.Map<SpecialtyDto>(repository.GetById(id));

    public void Post(SpecialtyDto dtoData)
    {
        repository.Post(mapper.Map<Specialty>(dtoData));
    }

    public bool Put(string id, SpecialtyDto dtoData) => repository.Put(id, mapper.Map<Specialty>(dtoData)); 
}
