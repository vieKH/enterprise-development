﻿namespace EducationDepartment.Domain;

public class DepartmentSpecialty(string departmentId, string specialtyId)
{
    public string DepartmentId { get; set; } = departmentId;
    public string SpecialtyId { get; set; } = specialtyId;
}

