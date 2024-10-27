﻿using AutoMapper;
using EducationDepartment.API.Dto;
using EducationDepartment.Domain.Repositories;

namespace EducationDepartment.API.Services;

/// <summary>
/// Class for query's service
/// </summary>
/// <param name="queryRepository">Query's repository</param>
/// <param name="mapper">Mapper</param>
public class QueryService(QueryRepository queryRepository, IMapper mapper)
{
    public UniversityDto? InfoUniversityByRegistration(string registrationNumber) => mapper.Map<UniversityDto>(queryRepository.InfoUniversityByRegistration(registrationNumber));
    
    public IEnumerable<UniversityAndDepartmentsDto> TotalDepartmentsInUniversity()
    {
        return from data in queryRepository.TotalDepartmentsInUniversity()
               select new UniversityAndDepartmentsDto
               {
                  NameUniversity = data.Item1,
                  RegistrationNumber = data.Item2,
                  TotalDepartments = data.Item3
               };
    }

    public IEnumerable<SpecialtyAndGroupsDto> TopFiveSpecialties()
    {
        return from data in queryRepository.TopFiveSpecialties()
               select new SpecialtyAndGroupsDto
               {
                   NameSpecialty = data.Item1,
                   TotalGroups = data.Item2
               };
    }

    public IEnumerable<PropertyAndGroupsDto> TotalGroupsByProperty(string propertyType)
    {
        return from data in queryRepository.TotalGroupsByProperty(propertyType)
               select new PropertyAndGroupsDto
               {
                   RegistrationNumber = data.Item1,
                   NameUniversity = data.Item2,
                   PropertyType = propertyType,
                   TotalGroups = data.Item4
               };
    }

    public IEnumerable<FacultyAndSpecialtyDto> InfoFacultiesSpecialties(string nameUniversity)
    {
        return from data in queryRepository.InfoFacultiesSpecialties(nameUniversity)
               select new FacultyAndSpecialtyDto
               {
                   NameUniversity = nameUniversity,
                   NameFaculty = data.Item2,
                   NameDepartment = data.Item3,
                   NameSpecialty = data.Item4
               };
    }

    public IEnumerable<PropertyAndBuildingDto> TotalDepartmentsFacultiesSpecialtiesByPropertyBuilding()
    {
        return from data in queryRepository.TotalDepartmentsFacultiesSpecialtiesByPropertyBuilding()
               select new PropertyAndBuildingDto
               {
                   PropertyType = data.Item1,
                   BuildingOwnership = data.Item2,
                   TotalSpecialties = data.Item3,
                   TotalFaculties = data.Item4,
                   TotalDepartments = data.Item5
               };
    }
}
