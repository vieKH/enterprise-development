using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repository;

public interface IRepository
{
    public IEnumerable<Department> GetDepartments();
    public Department? GetDepartment(string departmentId);
    public void PostDepartment(Department department);
    public bool PutDepartment(string id, Department department);
    public bool DeleteDepartment(string departmentId);

    public IEnumerable<DepartmentSpecialty> GetDepartmentSpecialties();
    public DepartmentSpecialty? GetDepartmentSpecialty(string departmentId);
    public void PostDepartmentSpecialty(DepartmentSpecialty departmentSpecialty);
    public bool PutDepartmentSpecialty(string id, DepartmentSpecialty departmentSpecialty);
    public bool DeleteDepartmentSpecialty(string departmentSpecialtyId);

    public IEnumerable<Faculty> GetFaculties();
    public Faculty? GetFaculty(int facultyId);
    public void PostFaculty(Faculty faculty);
    public bool PutFaculty(int id, Faculty faculty);
    public bool DeleteFaculty(int facultyId);

    public IEnumerable<Specialty> GetSpecialties();
    public Specialty? GetSpecialty(string specialtyId);
    public void PostSpecialty(Specialty specialty);
    public bool PutSpecialty(string id, Specialty specialty);
    public bool DeleteSpecialty(string specialtyId);


    public IEnumerable<University> GetUniversities();
    public University? GetUniversity(string registrationNumber);
    public void PostUniversity(University university);
    public bool PutUniversity(string id, University university);
    public bool DeleteUniversity(string registrationNumber);

}
