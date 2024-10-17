using AutoMapper;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Entity;
using EducationDepartment.Domain.Repositories;

namespace EducationDepartment.API.Services;

public class FacultyService(FacultyRepository repository, IMapper mapper): IService<FacultyDto>
{
    public bool Delete(string id) => repository.Delete(id);

    public IEnumerable<FacultyDto> GetAll() => repository.GetAll().Select(mapper.Map<FacultyDto>);

    public FacultyDto? GetById(string id) => mapper.Map<FacultyDto>(repository.GetById(id));

    public void Post(FacultyDto dtoData)
    {
        repository.Post(mapper.Map<Faculty>(dtoData));
    }

    public bool Put(FacultyDto dtoData) => repository.Put(mapper.Map<Faculty>(dtoData));
}
