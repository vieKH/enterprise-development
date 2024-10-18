namespace EducationDepartment.API.Services;

public interface IService<T>
{
    public IEnumerable<T> GetAll();

    public T? GetById(string id);

    public void Post(T dtoData);

    public bool Put(T dtoData);

    public bool Delete(string id);
}
