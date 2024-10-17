using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class DeparmentSpecialtyRepository(Database database) : IRepository<DepartmentSpecialty>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        database.DepartmentSpecialtyList.Remove(value);

        return true;
    }

    public IEnumerable<DepartmentSpecialty> GetAll() => database.DepartmentSpecialtyList;

    public DepartmentSpecialty? GetById(string id) => database.DepartmentSpecialtyList.Find(a => a.SpecialtyId == id);

    public void Post(DepartmentSpecialty data)
    {
        database.DepartmentSpecialtyList.Add(data);
    }

    public bool Put(DepartmentSpecialty data)
    {
        var oldValue = GetById(data.SpecialtyId);

        if (oldValue == null)
            return false;
        oldValue.DepartmentId = data.DepartmentId;
        oldValue.SpecialtyId = data.SpecialtyId;

        return true;
    }
}
