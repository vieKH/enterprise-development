using EducationDepartment.Domain;

namespace EducationDepartment.Test;

public class EducationDepartmentFixture
{
    public List<DepartmentSpecialty> DepartmentSpecialtyList { get; set; }
    public List<Faculty> FacultyList { get; set; }
    public List<Specitalty> SpecitaltyList { get; set; }
    public List<University> UniversityList { get; set; }
    public List<UniversitySpecialty> UniversitySpecialtyList { get; set; }

    public EducationDepartmentFixture()
    {
        UniversityList =
            [
                new University("UNI001", "University of Technology and Economics", "34 Tech Street", "Municipal", "Federal", "Ivan Yefimovich Petrov", "PhD", "Professor"),
                new University("UNI002", "Medical University", "456 Health Road", "Private", "Private", "Anna Ivanova Vladimirovna", "Doctor", "Professor"),
                new University("UNI003", "Pedagogical University", "321 Education Street", "Municipal", "Municipal", "Olga Petrova", "PhD", "Professor"),
                new University("UNI004", "University of Arts", "654 Art Boulevard", "Private", "Private", "Marina Vasilievna Smirnova", "MA", "Associate Professor"),
                new University("UNI005", "Law University", "852 Justice Boulevard", "Private", "Municipal", "Nikolai Vasilyevich Sergeev", "PhD", "Professor"),
                new University("UNI006", "University of Foreign Languages", "741 Pology Street", "Municipal", "Municipal", "Tatiana Nikolaevna Fedorova", "PhD", "Professor"),
                new University("UNI007", "Sports University", "963 Lenin Prospekt", "Municipal", "Federal", "Sergey Sergeevich Kozlov", "PhD", "Professor"),
             ];

        FacultyList =
            [
                new Faculty(1001, "Faculty of Information Technology", "UNI001"),
                new Faculty(1002, "Faculty of Mechanical Engineering", "UNI001"),
                new Faculty(1003, "Faculty of Finance and Banking", "UNI001"),
                new Faculty(1004, "Faculty of Translation", "UNI006"),
                new Faculty(2001, "Faculty of Medicine", "UNI002"),
                new Faculty(2002, "Faculty of Agronomy", "UNI002"),
                new Faculty(3001, "Faculty of Pedagogye", "UNI003"),
                new Faculty(4001, "Faculty of Fine Arts", "UNI004"),
                new Faculty(4002, "Faculty of Translation", "UNI004"),
                new Faculty(4003, "Faculty of Sports Science", "UNI004"),
                new Faculty(5001, "Faculty of International Law", "UNI005"),
                new Faculty(6001, "Faculty of Information Technology", "UNI006"),
                new Faculty(6002, "Faculty of Pedagogye", "UNI006"),
                new Faculty(6003, "Faculty of Translation", "UNI006"),
                new Faculty(6004, "Faculty of Finance and Banking", "UNI006"),
                new Faculty(7001, "Faculty of Sports Science", "UNI007")
            ];

        SpecitaltyList =
            [
                new Specitalty(1, "CS101", "Computer Science"),
                new Specitalty(2, "ME102", "Mechanical Engineering"),
                new Specitalty(3, "MD103", "Medicine"),
                new Specitalty(4, "FB104", "Finance and Banking"),
                new Specitalty(5, "PD105", "Pedagogye"),
                new Specitalty(6, "FA106", "Fine Arts"),
                new Specitalty(7, "AG107", "Agronomy"),
                new Specitalty(8, "LW108", "Law"),
                new Specitalty(9, "TR109", "Translation Studies"),
                new Specitalty(10, "SP110", "Sports Science")
            ];

        DepartmentSpecialtyList =
            [
                new DepartmentSpecialty(1001, 1),
                new DepartmentSpecialty(1002, 2),
                new DepartmentSpecialty(1003, 4),
                new DepartmentSpecialty(1004, 9),
                new DepartmentSpecialty(2001, 3),
                new DepartmentSpecialty(2002, 7),
                new DepartmentSpecialty(2002, 8),
                new DepartmentSpecialty(3001, 5),
                new DepartmentSpecialty(3001, 7),
                new DepartmentSpecialty(3001, 8),
                new DepartmentSpecialty(3001, 10),
                new DepartmentSpecialty(4001, 6),
                new DepartmentSpecialty(4002, 9),
                new DepartmentSpecialty(4003, 10),
                new DepartmentSpecialty(5001, 8),
                new DepartmentSpecialty(5001, 9),
                new DepartmentSpecialty(6001, 1),
                new DepartmentSpecialty(6002, 5),
                new DepartmentSpecialty(6002, 8),
                new DepartmentSpecialty(6003, 9),
                new DepartmentSpecialty(6004, 4),
                new DepartmentSpecialty(7001, 10)
            ];


        UniversitySpecialtyList =
            [
                new UniversitySpecialty("UNI001", 1, 7),
                new UniversitySpecialty("UNI001", 2, 5),
                new UniversitySpecialty("UNI001", 4, 5),
                new UniversitySpecialty("UNI001", 9, 5),
                new UniversitySpecialty("UNI002", 3, 10),
                new UniversitySpecialty("UNI002", 7, 10),
                new UniversitySpecialty("UNI002", 8, 10),
                new UniversitySpecialty("UNI003", 5, 10),
                new UniversitySpecialty("UNI003", 7, 10),
                new UniversitySpecialty("UNI003", 8, 10),
                new UniversitySpecialty("UNI004", 6, 10),
                new UniversitySpecialty("UNI004", 9, 10),
                new UniversitySpecialty("UNI004", 10, 10),
                new UniversitySpecialty("UNI005", 8, 10),
                new UniversitySpecialty("UNI005", 9, 10),
                new UniversitySpecialty("UNI006", 1, 10),
                new UniversitySpecialty("UNI006", 4, 10),
                new UniversitySpecialty("UNI006", 5, 10),
                new UniversitySpecialty("UNI006", 8, 10),
                new UniversitySpecialty("UNI006", 9, 10),
                new UniversitySpecialty("UNI007", 1, 10),
            ];
    }
}
