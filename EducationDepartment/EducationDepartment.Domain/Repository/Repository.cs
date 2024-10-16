using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repository;

public class Repository : IRepository
{
    private readonly List<Department> _departments = [];

    private readonly List<DepartmentSpecialty> _departmentSpecialties = [];

    private readonly List<Faculty> _faculties = [];

    private readonly List<Specialty> _specialties = [];

    private readonly List<University> _universties = [];

    public bool DeleteDepartment(string departmentId)
    {
        var value = GetDepartment(departmentId);

        if (value == null)
            return false;

        _departments.Remove(value);

        return true;
    }

    public bool DeleteDepartmentSpecialty(string departmentSpecialtyId)
    {
        var value = GetDepartmentSpecialty(departmentSpecialtyId);

        if (value == null)
            return false;

        _departmentSpecialties.Remove(value);

        return true;
    }

    public bool DeleteFaculty(int facultyId)
    {
        var value = GetFaculty(facultyId);

        if (value == null)
            return false;

        _faculties.Remove(value);

        return true;
    }

    public bool DeleteSpecialty(string specialtyId)
    {
        var value = GetSpecialty(specialtyId);

        if (value == null)
            return false;

        _specialties.Remove(value);

        return true;
    }

    public bool DeleteUniversity(string registrationNumber)
    {
        var value = GetUniversity(registrationNumber);

        if (value == null)
            return false;

        _universties.Remove(value);

        return true;
    }

    public IEnumerable<Department> GetDepartments() => _departments;

    public IEnumerable<DepartmentSpecialty> GetDepartmentSpecialties() => _departmentSpecialties;

    public IEnumerable<University> GetUniversities() => _universties;

    public IEnumerable<Faculty> GetFaculties() => _faculties;

    public IEnumerable<Specialty> GetSpecialties() => _specialties;

    public DepartmentSpecialty? GetDepartmentSpecialty(string departmentId) => _departmentSpecialties.Find(a => a.DepartmentId == departmentId);

    public Department? GetDepartment(string departmentId) => _departments.Find(b => b.DepartmentId == departmentId);

    public Faculty? GetFaculty(int facultyId) => _faculties.Find(c => c.FacultyId == facultyId);

    public Specialty? GetSpecialty(string specialtyId) => _specialties.Find(d => d.SpecialtyId == specialtyId);
    
    public University? GetUniversity(string registrationNumber) => _universties.Find(e => e.RegistrationNumber == registrationNumber);

    public void PostDepartment(Department department)
    {
        _departments.Add(department);
    }

    public void PostDepartmentSpecialty(DepartmentSpecialty departmentSpecialty)
    {
        _departmentSpecialties.Add(departmentSpecialty);
    }

    public void PostFaculty(Faculty faculty)
    {
        _faculties.Add(faculty);
    }

    public void PostSpecialty(Specialty specialty)
    {
        _specialties.Add(specialty);
    }

    public void PostUniversity(University university)
    {
        _universties.Add(university);
    }

    public bool PutDepartment(string id, Department department)
    {
        var oldValue = GetDepartment(id);

        if (oldValue == null)
            return false;

        oldValue.NameDepartment = department.NameDepartment;
        oldValue.DepartmentId = department.DepartmentId;
        oldValue.FacultyId = department.FacultyId;

        return true;
    }

    public bool PutDepartmentSpecialty(string id, DepartmentSpecialty departmentSpecialty)
    {
        var oldValue = GetDepartmentSpecialty(id);

        if (oldValue == null)
            return false;

        oldValue.DepartmentId = departmentSpecialty.DepartmentId;
        oldValue.SpecialtyId = departmentSpecialty.SpecialtyId;

        return true;
    }

    public bool PutFaculty(int id, Faculty faculty)
    {
        var oldValue = GetFaculty(id);

        if (oldValue == null)
            return false;

        oldValue.FacultyId = faculty.FacultyId;
        oldValue.NameFaculty = faculty.NameFaculty;
        oldValue.RegistrationNumber = faculty.RegistrationNumber;

        return true;
    }

    public bool PutSpecialty(string id, Specialty specialty)
    {
        var oldValue = GetSpecialty(id);

        if (oldValue == null)
            return false;

        oldValue.NameSpecialty = specialty.NameSpecialty;
        oldValue.SpecialtyId = specialty.SpecialtyId;
        oldValue.NumberOfGroups = specialty.NumberOfGroups;

        return true;
    }

    public bool PutUniversity(string id, University university)
    {
        var oldValue = GetUniversity(id);

        if (oldValue == null)
            return false;

        oldValue.RegistrationNumber = university.RegistrationNumber;
        oldValue.Address = university.Address;
        oldValue.NameUniversity = university.NameUniversity;
        oldValue.RectorFullName = university.RectorFullName;
        oldValue.Tittle = university.Tittle;
        oldValue.BuildingOwnership = university.BuildingOwnership;
        oldValue.Degree = university.Degree;
        oldValue.PropertyType = university.PropertyType;

        return true;
    }
}
