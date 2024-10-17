using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class FacultyRepository(Database database) : IRepository<Faculty>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        database.FacultyList.Remove(value);

        return true;
    }

    public IEnumerable<Faculty> GetAll() => database.FacultyList;
    public Faculty? GetById(string id) => database.FacultyList.Find(a => a.FacultyId == id);

    public void Post(Faculty data)
    {
        database.FacultyList.Add(data);
    }

    public bool Put(string id, Faculty data)
    {
        var oldValue = GetById(id);

        if (oldValue == null)
            return false;

        oldValue.FacultyId = data.FacultyId;
        oldValue.NameFaculty = data.NameFaculty;
        oldValue.RegistrationNumber = data.RegistrationNumber;

        return true;
    }
}
