namespace EducationDepartment.API.Services;

public interface IService<D>
{
    public IEnumerable<D> GetAll();

    public D? GetById(string id);

    public void Post(D dtoData);

    public bool Put(D dtoData);

    public bool Delete(string id);
}
