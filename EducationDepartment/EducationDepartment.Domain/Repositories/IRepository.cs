using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public interface IRepository<T>
{
    public IEnumerable<T> GetAll();

    public T? GetById(string id);

    public void Post(T data);

    public bool Put(T data);

    public bool Delete(string id);
}
