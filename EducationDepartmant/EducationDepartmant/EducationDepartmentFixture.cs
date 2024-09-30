using EducationDepartment.Domain;

namespace EducationDepartment.Test;

public class EducationDepartmentFixture
{
    public List<DepartmentSpecialty> DepartmentSpecialtyList { get; set; }
    public List<Faculty> FacultyList { get; set; }
    public List<Specitalty> SpecitaltyList { get; set; }
    public List<Department> DepartmentsList {  get; set; }
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
                new Faculty(1004, "Faculty of Translation", "UNI001"),

                new Faculty(2001, "Faculty of Medicine", "UNI002"),
                new Faculty(2002, "Faculty of Agronomy", "UNI002"),

                new Faculty(3001, "Faculty of Pedagogye", "UNI003"),

                new Faculty(4001, "Faculty of Fine Arts", "UNI004"),
                new Faculty(4002, "Faculty of Translation", "UNI004"),
                new Faculty(4003, "Faculty of Sports Science", "UNI004"),

                new Faculty(5001, "Faculty of International Law", "UNI005"),

                new Faculty(6001, "Faculty of Information Technology" , "UNI006"),
                new Faculty(6002, "Faculty of Pedagogye", "UNI006"),
                new Faculty(6003, "Faculty of Translation", "UNI006"),
                new Faculty(6004, "Faculty of Finance and Banking", "UNI006"),

                new Faculty(7001, "Faculty of Sports Science", "UNI007")
            ];

        DepartmentsList =
            [
                new Department(1001, "Department of Software Engineering", "1001-DSE"),
                new Department(1001, "Department of Information", "1001-DI"),
                new Department(1002, "Department of Robotics", "1002-DR"),
                new Department(1003, "Department of Finance", "1003-DF"),
                new Department(1004, "Department of Languages", "1004-DL"),

                new Department(2001, "Department of Surgery", "2001-DS"),
                new Department(2002, "Department of Pharmacy", "2002-DP"),

                new Department(3001, "Department of Crop Production", "3001-DCP"),

                new Department(4001, "Department of Painting", "4001-DP"),
                new Department(4001, "Department of Drawing", "4001-DD"),
                new Department(4002, "Department of Languages", "4002-DL"),
                new Department(4003, "Department of Sports Physiologys", "4003-DSP"),

                new Department(5001, "Department of Law", "5001-DL"),

                new Department(6001, "Department of Information", "6001-DI"),
                new Department(6002, "Department of Science Education", "6002-DSE"),
                new Department(6003, "Department of Languages", "6003-DL"),
                new Department(6004, "Department of Finance", "6004-DF"),

                new Department(7001, "Department of Sports Physiologys", "7001-DSP"),
         
            ];

        SpecitaltyList =
            [
                new Specitalty("1001.05.03", "Computer Software Science"),
                new Specitalty("1001.04.03", "Computer Science"),
                new Specitalty("1002.05.01", "Mechanical Engineering"),
                new Specitalty("1002.04.02", "Mechanical Collaboration"),
                new Specitalty("1003.04.05", "Finance and Banking"),
                new Specitalty("1004.04.03", "Translation Studies"),
                new Specitalty("2001.06.02", "Doctor"),
                new Specitalty("2001.05.02", "Medicine"),
                new Specitalty("2002.04.02", "Agronomy"),
                new Specitalty("2002.04.04", "Pedagogye"),
                new Specitalty("3001.04.01", "Pedagogye"),
                new Specitalty("3001.04.03", "Sports Science"),
                new Specitalty("4001.04.01", "Fine Arts"),
                new Specitalty("4001.04.04", "Beauty Arts"),
                new Specitalty("4002.04.02", "Translation Studies"),
                new Specitalty("4003.04.03", "Sports Science"),
                new Specitalty("5001.05.02", "International Law"),
                new Specitalty("5001.04.01", "Foreign Law"),
                new Specitalty("6001.05.02", "Computer Software Science"),
                new Specitalty("6002.04.02", "Pedagogye"),
                new Specitalty("6003.04.02", "Translation Studies"),
                new Specitalty("6004.04.02", "Finance and Banking"),
                new Specitalty("7001.03.02", "Sports Science")
            ];

        DepartmentSpecialtyList =
            [
                new DepartmentSpecialty("1001-DSE", "1001.05.03"),
                new DepartmentSpecialty("1001-DI", "1001.04.03"),
                new DepartmentSpecialty("1002-DR", "1002.05.01"),
                new DepartmentSpecialty("1002-DR", "1002.04.02"),
                new DepartmentSpecialty("1003-DF", "1003.04.05"),
                new DepartmentSpecialty("1004-DL", "1004.04.03"),
                new DepartmentSpecialty("2001-DS", "2001.06.02"),
                new DepartmentSpecialty("2001-DS", "2001.05.02"),
                new DepartmentSpecialty("2002-DP", "2002.04.02"),
                new DepartmentSpecialty("2002-DP", "2002.04.04"),
                new DepartmentSpecialty("3001-DCP", "3001.04.01"),
                new DepartmentSpecialty("3001-DCP", "3001.04.03"),
                new DepartmentSpecialty("4001-DP", "4001.04.01"),
                new DepartmentSpecialty("4001-DD", "4001.04.04"),
                new DepartmentSpecialty("4002-DL", "4002.04.02"),
                new DepartmentSpecialty("4003-DSP", "4003.04.03"),
                new DepartmentSpecialty("5001-DL", "5001.05.02"),
                new DepartmentSpecialty("5001-DL", "5001.04.01"),
                new DepartmentSpecialty("6001-DI", "6001.05.02"),
                new DepartmentSpecialty("6002-DSE", "6002.04.02"),
                new DepartmentSpecialty("6003-DL", "6003.04.02"),
                new DepartmentSpecialty("6004-DF", "6004.04.02"),
                new DepartmentSpecialty("7001-DSP", "7001.03.02"),
            ];


        UniversitySpecialtyList =
            [
                new UniversitySpecialty("UNI001", "1001.05.03", 7),
                new UniversitySpecialty("UNI001", "1001.04.03", 8),
                new UniversitySpecialty("UNI001", "1002.05.01", 10),
                new UniversitySpecialty("UNI001", "1002.04.02", 5),
                new UniversitySpecialty("UNI001", "1003.04.05", 9),
                new UniversitySpecialty("UNI001", "1004.04.03", 11),
                new UniversitySpecialty("UNI002", "2001.06.02", 5),
                new UniversitySpecialty("UNI002", "2001.05.02", 3),
                new UniversitySpecialty("UNI002", "2002.04.02", 4),
                new UniversitySpecialty("UNI002", "2002.04.04", 6),
                new UniversitySpecialty("UNI003", "3001.04.01", 8),
                new UniversitySpecialty("UNI003", "3001.04.03", 2),
                new UniversitySpecialty("UNI004", "4001.04.01", 5),
                new UniversitySpecialty("UNI004", "4001.04.04", 6),
                new UniversitySpecialty("UNI004", "4002.04.02", 6),
                new UniversitySpecialty("UNI004", "4003.04.03", 4),
                new UniversitySpecialty("UNI005", "5001.05.02", 3),
                new UniversitySpecialty("UNI005", "5001.04.01", 5),
                new UniversitySpecialty("UNI006", "6001.05.02", 7),
                new UniversitySpecialty("UNI006", "6002.04.02", 8),
                new UniversitySpecialty("UNI006", "6003.04.02", 8),
                new UniversitySpecialty("UNI006", "6004.04.02", 5),
                new UniversitySpecialty("UNI007", "7001.03.02", 7)
            ];
    }
}
