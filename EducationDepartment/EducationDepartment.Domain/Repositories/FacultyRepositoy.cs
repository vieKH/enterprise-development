using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class FacultyRepository(EducationDepartmentContext educationDepartmentContext) : IRepository<Faculty>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        educationDepartmentContext.Faculty.Remove(value);
        educationDepartmentContext.SaveChanges();

        return true;
    }

    public IEnumerable<Faculty> GetAll() => educationDepartmentContext.Faculty;

    public Faculty? GetById(string id) => educationDepartmentContext.Faculty.FirstOrDefault(a => a.FacultyId == id);

    public void Post(Faculty data)
    {
        educationDepartmentContext.Faculty.Add(data);
        educationDepartmentContext.SaveChanges();
    }

    public bool Put(Faculty data)
    {
        var oldValue = GetById(data.FacultyId);

        if (oldValue == null)
            return false;

        educationDepartmentContext.Update(data);
        educationDepartmentContext.SaveChanges();

        return true;
    }
}
