using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class SpecialtyRepository(Database database) : IRepository<Specialty>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        database.SpecialtyList.Remove(value);

        return true;
    }

    public IEnumerable<Specialty> GetAll() => database.SpecialtyList;

    public Specialty? GetById(string id) => database.SpecialtyList.Find(a => a.SpecialtyId == id);

    public void Post(Specialty data)
    {
        database.SpecialtyList.Add(data);
    }

    public bool Put(Specialty data)
    {
        var oldValue = GetById(data.SpecialtyId);

        if (oldValue == null)
            return false;

        oldValue.NameSpecialty = data.NameSpecialty;
        oldValue.SpecialtyId = data.SpecialtyId;
        oldValue.NumberOfGroups = data.NumberOfGroups;

        return true;
    }
}
