using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class DepartmentRepository(Database database) : IRepository<Department>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        database.DepartmentsList.Remove(value);

        return true;
    }

    public IEnumerable<Department> GetAll() => database.DepartmentsList;
    public Department? GetById(string id) => database.DepartmentsList.Find(a => a.DepartmentId == id);

    public void Post(Department data)
    {
        database.DepartmentsList.Add(data);
    }

    public bool Put(string id, Department data)
    {
        var oldValue = GetById(id);

        if (oldValue == null)
            return false;

        oldValue.NameDepartment = data.NameDepartment;
        oldValue.DepartmentId = data.DepartmentId;
        oldValue.FacultyId = data.FacultyId;

        return true;
    }
}
