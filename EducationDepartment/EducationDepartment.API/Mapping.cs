﻿using AutoMapper;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Entity;

namespace EducationDepartment.API;

public class Mapping: Profile
{
    public Mapping()
    {
        CreateMap<Department, DepartmentDto>().ReverseMap();
        CreateMap<DepartmentSpecialty, DepartmentSpecialtyDto>().ReverseMap();
        CreateMap<Faculty, FacultyDto>().ReverseMap();
        CreateMap<Specialty, SpecialtyDto>().ReverseMap();
        CreateMap<University, UniversityDto>().ReverseMap();
    }
}
