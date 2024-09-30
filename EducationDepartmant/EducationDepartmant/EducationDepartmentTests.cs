using System.Globalization;
namespace EducationDepartment.Test;


public class EducationDepartmentTests(EducationDepartmentFixture fixture) : IClassFixture<EducationDepartmentFixture>
{
    private readonly EducationDepartmentFixture _fixture = fixture;

    [Fact]
    public void InfoUniversity()
    {
        var infoUniversity = (from university in _fixture.UniversityList
                              where university.Name == "University of Foreign Languages"
                              select new
                              {
                                  university.RegistrationNumber,
                                  university.Name,
                                  university.Adress,
                                  university.PropertyType,
                                  university.BuildingOwership,
                                  university.RectorFullName,
                                  university.Degree,
                                  university.Tittle
                              }).ToList();


        Assert.Equal("UNI006", infoUniversity[0].RegistrationNumber);
        Assert.Equal("University of Foreign Languages", infoUniversity[0].Name);
        Assert.Equal("741 Pology Street", infoUniversity[0].Adress);
        Assert.Equal("Municipal", infoUniversity[0].PropertyType);
        Assert.Equal("Municipal", infoUniversity[0].BuildingOwership);
        Assert.Equal("Tatiana Nikolaevna Fedorova", infoUniversity[0].RectorFullName);
        Assert.Equal("PhD", infoUniversity[0].Degree);
        Assert.Equal("Professor", infoUniversity[0].Tittle);

    }

}

