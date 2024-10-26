using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class DepartmentRepository(EducationDepartmentContext educationDepartmentContext) : IRepository<Department>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        educationDepartmentContext.Department.Remove(value);
        educationDepartmentContext.SaveChanges();

        return true;
    }

    public IEnumerable<Department> GetAll() => educationDepartmentContext.Department;

    public Department? GetById(string id) => educationDepartmentContext.Department.FirstOrDefault(a => a.DepartmentId == id);

    public void Post(Department data)
    {
        educationDepartmentContext.Department.Add(data);
        educationDepartmentContext.SaveChanges();
    }

    public bool Put(Department data)
    {
        var oldValue = GetById(data.DepartmentId);

        if (oldValue == null)
            return false;

        educationDepartmentContext.Update(data);
        educationDepartmentContext.SaveChanges();

        return true;
    }
}
