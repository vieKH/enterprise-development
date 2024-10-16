﻿using System.Net;

namespace EducationDepartment.API.Dto;

public class UniversityDto
{
    public required string RegistrationNumber { get; set; } 
    public required string NameUniversity { get; set; } 
    public required string Address { get; set; } 
    public required string PropertyType { get; set; }
    public required string BuildingOwnership { get; set; } 
    public required string RectorFullName { get; set; }
    public required string Degree { get; set; }
    public required string Tittle { get; set; } 
}