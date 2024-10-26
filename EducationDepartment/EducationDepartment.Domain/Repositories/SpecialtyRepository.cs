﻿using EducationDepartment.Domain.Entity;

namespace EducationDepartment.Domain.Repositories;

public class SpecialtyRepository(EducationDepartmentContext educationDepartmentContext) : IRepository<Specialty>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        educationDepartmentContext.Specialty.Remove(value);
        educationDepartmentContext.SaveChanges();

        return true;
    }

    public IEnumerable<Specialty> GetAll() => educationDepartmentContext.Specialty;

    public Specialty? GetById(string id) => educationDepartmentContext.Specialty.FirstOrDefault(a => a.SpecialtyId == id);

    public void Post(Specialty data)
    {
        educationDepartmentContext.Specialty.Add(data);
        educationDepartmentContext.SaveChanges();
    }

    public bool Put(Specialty data)
    {
        var oldValue = GetById(data.SpecialtyId);

        if (oldValue == null)
            return false;

        educationDepartmentContext.Update(data);
        educationDepartmentContext.SaveChanges();

        return true;
    }
}
