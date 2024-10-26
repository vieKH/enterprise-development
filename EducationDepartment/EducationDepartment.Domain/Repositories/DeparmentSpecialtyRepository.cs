﻿using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class DeparmentSpecialtyRepository(EducationDepartmentContext educationDepartmentContext) : IRepository<DepartmentSpecialty>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        educationDepartmentContext.DepartmentSpecialty.Remove(value);
        educationDepartmentContext.SaveChanges();

        return true;
    }

    public IEnumerable<DepartmentSpecialty> GetAll() => educationDepartmentContext.DepartmentSpecialty;

    public DepartmentSpecialty? GetById(string id) => educationDepartmentContext.DepartmentSpecialty.FirstOrDefault(a => a.SpecialtyId == id);

    public void Post(DepartmentSpecialty data)
    {
        educationDepartmentContext.DepartmentSpecialty.Add(data);
        educationDepartmentContext.SaveChanges();
    }

    public bool Put(DepartmentSpecialty data)
    {
        var oldValue = GetById(data.SpecialtyId);

        if (oldValue == null)
            return false;
        
        educationDepartmentContext.Update(data);
        educationDepartmentContext.SaveChanges();

        return true;
    }
}
