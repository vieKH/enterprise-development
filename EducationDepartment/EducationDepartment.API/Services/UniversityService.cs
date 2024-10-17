using AutoMapper;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repositories;

namespace EducationDepartment.API.Services;

public class UniversityService(UniversityRepository repository, IMapper mapper) : IService<UniversityDto>
{
    public bool Delete(string id) => repository.Delete(id);

    public IEnumerable<UniversityDto> GetAll() => repository.GetAll().Select(mapper.Map<UniversityDto>);

    public UniversityDto? GetById(string id) => mapper.Map<UniversityDto>(repository.GetById(id));

    public void Post(UniversityDto dtoData)
    {
        repository.Post(mapper.Map<University>(dtoData)); 
    }
    public bool Put(string id, UniversityDto dtoData) => repository.Put(id, mapper.Map<University>(dtoData));
}
