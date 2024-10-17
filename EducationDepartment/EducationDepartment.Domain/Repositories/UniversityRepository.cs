using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class UniversityRepository(Database database) : IRepository<University>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        database.UniversityList.Remove(value);

        return true;
    }

    public IEnumerable<University> GetAll() => database.UniversityList;

    public University? GetById(string id) => database.UniversityList.Find(a => a.RegistrationNumber == id);

    public void Post(University data)
    {
        database.UniversityList.Add(data);
    }

    public bool Put(University data)
    {
        var oldValue = GetById(data.RegistrationNumber);

        if (oldValue == null)
            return false;

        oldValue.RegistrationNumber = data.RegistrationNumber;
        oldValue.Address = data.Address;
        oldValue.NameUniversity = data.NameUniversity;
        oldValue.RectorFullName = data.RectorFullName;
        oldValue.Tittle = data.Tittle;
        oldValue.BuildingOwnership = data.BuildingOwnership;
        oldValue.Degree = data.Degree;
        oldValue.PropertyType = data.PropertyType;

        return true;
    }
}
