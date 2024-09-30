namespace EducationDepartment.Test;

public class EducationDepartmentTests(EducationDepartmentFixture fixture) : IClassFixture<EducationDepartmentFixture>
{
    private readonly EducationDepartmentFixture _fixture = fixture;

    [Fact]
    public void InfoUniversity()
    {
        var infoUniversity = (from university in _fixture.UniversityList
                              where university.RegistrationNumber is "UNI006"
                              select new
                              {
                                  university.RegistrationNumber,
                                  university.NameUni,
                                  university.Adress,
                                  university.PropertyType,
                                  university.BuildingOwnership,
                                  university.RectorFullName,
                                  university.Degree,
                                  university.Tittle
                              }).ToList();


        Assert.Equal("UNI006", infoUniversity[0].RegistrationNumber);
        Assert.Equal("University of Foreign Languages", infoUniversity[0].NameUni);
        Assert.Equal("741 Pology Street", infoUniversity[0].Adress);
        Assert.Equal("Municipal", infoUniversity[0].PropertyType);
        Assert.Equal("Municipal", infoUniversity[0].BuildingOwnership);
        Assert.Equal("Tatiana Nikolaevna Fedorova", infoUniversity[0].RectorFullName);
        Assert.Equal("PhD", infoUniversity[0].Degree);
        Assert.Equal("Professor", infoUniversity[0].Tittle);
    }

    [Fact]
    public void InfoFacultySpecialty()
    {
        var result = (from faculty in _fixture.FacultyList
                      join university in _fixture.UniversityList on faculty.RegistrationNumber equals university.RegistrationNumber
                      join department in _fixture.DepartmentsList on faculty.FacultyId equals department.FacultyId
                      join depSpecialty in _fixture.DepartmentSpecialtyList on department.DepartmentId equals depSpecialty.DepartmentId
                      join specialty in _fixture.SpecialtyList on depSpecialty.SpecialtyId equals specialty.SpecialtyId
                      where university.NameUni is "University of Technology and Economics"
                      orderby faculty.NameFa
                      select new
                      {
                          university.NameUni,
                          faculty.NameFa,
                          department.NameDep,
                          specialty.NameSp
                      }
            ).ToList();

        Assert.Equal(result,
            [
                new {NameUni = "University of Technology and Economics", NameFa = "Faculty of Finance and Banking", NameDep = "Department of Finance", NameSp="Finance and Banking"},
                new {NameUni = "University of Technology and Economics", NameFa = "Faculty of Information Technology", NameDep = "Department of Software Engineering", NameSp="Computer Software Science"},
                new {NameUni = "University of Technology and Economics", NameFa = "Faculty of Information Technology", NameDep = "Department of Information", NameSp="Computer Science"},
                new {NameUni = "University of Technology and Economics", NameFa = "Faculty of Mechanical Engineering", NameDep = "Department of Robotics", NameSp="Mechanical Engineering"},
                new {NameUni = "University of Technology and Economics", NameFa = "Faculty of Mechanical Engineering", NameDep = "Department of Robotics", NameSp="Mechanical Collaboration"},
                new {NameUni = "University of Technology and Economics", NameFa = "Faculty of Translation", NameDep = "Department of Languages", NameSp="Translation Studies"},
            ]);
    }

    [Fact]
    public void TopFiveSpecialtyWithGroup()
    {   
        var result = (from specialty in _fixture.SpecialtyList
                      group specialty by specialty.NameSp into table
                      select new
                      {
                          NameSpe = table.Key,
                          TotalGroups = table.Sum(p => p.NumberOfGroups)
                      }
                      )
                      .OrderByDescending(p => p.TotalGroups)
                      .Take(5)
                      .ToList();
                      
        Assert.Equal(result,
            [
                new {NameSpe = "Translation Studies", TotalGroups = 25},
                new {NameSpe = "Pedagogye", TotalGroups = 22},
                new {NameSpe = "Computer Software Science", TotalGroups = 14},
                new {NameSpe = "Finance and Banking", TotalGroups = 14},
                new {NameSpe = "Sports Science", TotalGroups = 13}
            ]);
    }

    [Fact]
    public void InfoUniversityByOrderMaxDepartment()
    {
        var result = (from uni in _fixture.UniversityList
                      join faculty in _fixture.FacultyList on uni.RegistrationNumber equals faculty.RegistrationNumber
                      join department in _fixture.DepartmentsList on faculty.FacultyId equals department.FacultyId
                      group uni by new { uni.RegistrationNumber, uni.NameUni } into table
                      select new
                      {
                          UniName = table.Key.NameUni,
                          UniRegis = table.Key.RegistrationNumber,
                          UniDepartment = table.Count()
                      })
                      .OrderByDescending(x => x.UniDepartment)
                      .ThenByDescending(x => x.UniName)
                      .ToList();

        Assert.Equal(result,
            [
                new {UniName = "University of Technology and Economics", UniRegis = "UNI001", UniDepartment = 5},
                new {UniName = "University of Foreign Languages", UniRegis = "UNI006", UniDepartment = 4},
                new {UniName = "University of Arts", UniRegis = "UNI004", UniDepartment = 4},
                new {UniName = "Medical University", UniRegis = "UNI002", UniDepartment = 2},
                new {UniName = "Sports University", UniRegis = "UNI007", UniDepartment = 1},
                new {UniName = "Pedagogical University", UniRegis = "UNI003", UniDepartment = 1},
                new {UniName = "Law University", UniRegis = "UNI005", UniDepartment = 1},
            ]);
    }

    [Fact]
    public void InfoTotalGroupsByPropertyType()
    {
        var result = (from specialty in _fixture.SpecialtyList
                    join deSpe in _fixture.DepartmentSpecialtyList on specialty.SpecialtyId equals deSpe.SpecialtyId
                    join department in _fixture.DepartmentsList on deSpe.DepartmentId equals department.DepartmentId
                    join faculty in _fixture.FacultyList on department.FacultyId equals faculty.FacultyId
                    join uni in _fixture.UniversityList on faculty.RegistrationNumber equals uni.RegistrationNumber
                    where uni.PropertyType is "Private"
                    group specialty by new { uni.RegistrationNumber, uni.NameUni, uni.PropertyType } into table
                    select new
                    {
                        RegistrationNumber = table.Key.RegistrationNumber,
                        UniName = table.Key.NameUni,
                        Property = table.Key.PropertyType,
                        TotalGroups = table.Sum(p => p.NumberOfGroups)
                    })
                    .OrderByDescending(p=>p.TotalGroups)
                    .ToList();

        Assert.Equal(result,
            [
                new {RegistrationNumber = "UNI004", UniName = "University of Arts", Property = "Private", TotalGroups = 21},
                new {RegistrationNumber = "UNI002", UniName = "Medical University", Property = "Private", TotalGroups = 18},
                new {RegistrationNumber = "UNI005", UniName = "Law University", Property = "Private", TotalGroups = 8}
            ]);
    }

    [Fact]
    void InfoDepartmentsFacultiesSpecialtiesByBuildingAndProperty()
    {
        var tmp1 = (from specialty in _fixture.SpecialtyList
                    join deSpe in _fixture.DepartmentSpecialtyList on specialty.SpecialtyId equals deSpe.SpecialtyId
                    join department in _fixture.DepartmentsList on deSpe.DepartmentId equals department.DepartmentId
                    join faculty in _fixture.FacultyList on department.FacultyId equals faculty.FacultyId
                    join uni in _fixture.UniversityList on faculty.RegistrationNumber equals uni.RegistrationNumber
                    group specialty by new { uni.PropertyType, uni.BuildingOwnership } into table1
                    select new
                    {
                        PropertyType = table1.Key.PropertyType,
                        BuildingOwnership = table1.Key.BuildingOwnership,
                        TotalSpecialties = table1.Count()
                    }
            ).ToList();

        var tmp2 = (from faculty in _fixture.FacultyList
                    join university in _fixture.UniversityList on faculty.RegistrationNumber equals university.RegistrationNumber
                    group faculty by new { university.PropertyType, university.BuildingOwnership } into table2
                    select new
                    {
                        PropertyType = table2.Key.PropertyType,
                        BuildingOwnership = table2.Key.BuildingOwnership,
                        TotalFaculties = table2.Count()
                    }
            ).ToList();

        var tmp3 = (from department in _fixture.DepartmentsList
                    join falcuty in _fixture.FacultyList on department.FacultyId equals falcuty.FacultyId
                    join uni in _fixture.UniversityList on falcuty.RegistrationNumber equals uni.RegistrationNumber
                    group department by new { uni.PropertyType, uni.BuildingOwnership } into table3
                    select new
                    {
                        PropertyType = table3.Key.PropertyType,
                        BuildingOwnership = table3.Key.BuildingOwnership,
                        TotalDepartments = table3.Count()
                    }
            ).ToList();

        var result = (from temp1 in tmp1
                      join temp2 in tmp2 on temp1.PropertyType equals temp2.PropertyType where temp1.BuildingOwnership == temp2.BuildingOwnership
                      join temp3 in tmp3 on temp2.PropertyType equals temp3.PropertyType where temp2.BuildingOwnership == temp3.BuildingOwnership
                      select new
                      {
                          PropertyType=temp1.PropertyType,
                          BuildingOwnership = temp1.BuildingOwnership,
                          TotalSpecialties = temp1.TotalSpecialties,
                          TotalFaculties = temp2.TotalFaculties,
                          TotalDepartments = temp3.TotalDepartments
                      }
            )
            .OrderByDescending(p => p.TotalSpecialties)
            .ToList();
        Assert.Equal(result,
            [
                new{ PropertyType = "Private", BuildingOwnership = "Private", TotalSpecialties = 8, TotalFaculties = 5, TotalDepartments = 6},
                new{ PropertyType = "Municipal", BuildingOwnership = "Federal",  TotalSpecialties = 7, TotalFaculties = 5, TotalDepartments = 6},
                new{ PropertyType = "Municipal", BuildingOwnership = "Municipal",  TotalSpecialties = 6, TotalFaculties = 5, TotalDepartments = 5},
                new{ PropertyType = "Private", BuildingOwnership = "Municipal",  TotalSpecialties = 2, TotalFaculties = 1, TotalDepartments = 1},
            ]);
    }
}

