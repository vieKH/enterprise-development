﻿using EducationDepartment.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace EducationDepartment.Domain.Repositories;

public class UniversityRepository(EducationDepartmentContext educationDepartmentContext) : IRepository<University>
{
    public bool Delete(string id)
    {
        var value = GetById(id);

        if (value == null)
            return false;

        educationDepartmentContext.University.Remove(value);
        educationDepartmentContext.SaveChanges();
        
        return true;
    }

    public IEnumerable<University> GetAll() => educationDepartmentContext.University;

    public University? GetById(string id) => educationDepartmentContext.University.FirstOrDefault(a => a.RegistrationNumber == id);

    public void Post(University data)
    {
        educationDepartmentContext.University.Add(data);
        educationDepartmentContext.SaveChanges();
    }

    public bool Put(University data)
    {
        var oldValue = GetById(data.RegistrationNumber);

        if (oldValue == null)
        {
            return false;
        }

        educationDepartmentContext.Entry(oldValue).State = EntityState.Detached;

        educationDepartmentContext.Entry(data).State = EntityState.Modified;
     
        educationDepartmentContext.SaveChanges();
        return true;
 
    }
}
