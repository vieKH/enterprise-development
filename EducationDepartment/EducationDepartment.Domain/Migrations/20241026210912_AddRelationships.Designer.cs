﻿// <auto-generated />
using EducationDepartment.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EducationDepartment.Domain.Migrations
{
    [DbContext(typeof(EducationDepartmentContext))]
    [Migration("20241026210912_AddRelationships")]
    partial class AddRelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("EducationDepartment.Domain.Entity.Department", b =>
                {
                    b.Property<string>("DepartmentId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FacultyId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NameDepartment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DepartmentId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            DepartmentId = "1001-DSE",
                            FacultyId = "1001",
                            NameDepartment = "Department of Software Engineering"
                        },
                        new
                        {
                            DepartmentId = "1001-DI",
                            FacultyId = "1001",
                            NameDepartment = "Department of Information"
                        },
                        new
                        {
                            DepartmentId = "1002-DR",
                            FacultyId = "1002",
                            NameDepartment = "Department of Robotics"
                        },
                        new
                        {
                            DepartmentId = "1003-DF",
                            FacultyId = "1003",
                            NameDepartment = "Department of Finance"
                        },
                        new
                        {
                            DepartmentId = "1004-DL",
                            FacultyId = "1004",
                            NameDepartment = "Department of Languages"
                        },
                        new
                        {
                            DepartmentId = "2001-DS",
                            FacultyId = "2001",
                            NameDepartment = "Department of Surgery"
                        },
                        new
                        {
                            DepartmentId = "2002-DP",
                            FacultyId = "2002",
                            NameDepartment = "Department of Pharmacy"
                        },
                        new
                        {
                            DepartmentId = "3001-DCP",
                            FacultyId = "3001",
                            NameDepartment = "Department of Crop Production"
                        },
                        new
                        {
                            DepartmentId = "4001-DP",
                            FacultyId = "4001",
                            NameDepartment = "Department of Painting"
                        },
                        new
                        {
                            DepartmentId = "4001-DD",
                            FacultyId = "4001",
                            NameDepartment = "Department of Drawing"
                        },
                        new
                        {
                            DepartmentId = "4002-DL",
                            FacultyId = "4002",
                            NameDepartment = "Department of Languages"
                        },
                        new
                        {
                            DepartmentId = "4003-DSP",
                            FacultyId = "4003",
                            NameDepartment = "Department of Sports Physiologys"
                        },
                        new
                        {
                            DepartmentId = "5001-DL",
                            FacultyId = "5001",
                            NameDepartment = "Department of Law"
                        },
                        new
                        {
                            DepartmentId = "6001-DI",
                            FacultyId = "6001",
                            NameDepartment = "Department of Information"
                        },
                        new
                        {
                            DepartmentId = "6002-DSE",
                            FacultyId = "6002",
                            NameDepartment = "Department of Science Education"
                        },
                        new
                        {
                            DepartmentId = "6003-DL",
                            FacultyId = "6003",
                            NameDepartment = "Department of Languages"
                        },
                        new
                        {
                            DepartmentId = "6004-DF",
                            FacultyId = "6004",
                            NameDepartment = "Department of Finance"
                        },
                        new
                        {
                            DepartmentId = "7001-DSP",
                            FacultyId = "7001",
                            NameDepartment = "Department of Sports Physiologys"
                        });
                });

            modelBuilder.Entity("EducationDepartment.Domain.Entity.DepartmentSpecialty", b =>
                {
                    b.Property<string>("SpecialtyId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("SpecialtyId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentSpecialty");

                    b.HasData(
                        new
                        {
                            SpecialtyId = "1001.05.03",
                            DepartmentId = "1001-DSE"
                        },
                        new
                        {
                            SpecialtyId = "1001.04.03",
                            DepartmentId = "1001-DI"
                        },
                        new
                        {
                            SpecialtyId = "1002.05.01",
                            DepartmentId = "1002-DR"
                        },
                        new
                        {
                            SpecialtyId = "1002.04.02",
                            DepartmentId = "1002-DR"
                        },
                        new
                        {
                            SpecialtyId = "1003.04.05",
                            DepartmentId = "1003-DF"
                        },
                        new
                        {
                            SpecialtyId = "1004.04.03",
                            DepartmentId = "1004-DL"
                        },
                        new
                        {
                            SpecialtyId = "2001.06.02",
                            DepartmentId = "2001-DS"
                        },
                        new
                        {
                            SpecialtyId = "2001.05.02",
                            DepartmentId = "2001-DS"
                        },
                        new
                        {
                            SpecialtyId = "2002.04.02",
                            DepartmentId = "2002-DP"
                        },
                        new
                        {
                            SpecialtyId = "2002.04.04",
                            DepartmentId = "2002-DP"
                        },
                        new
                        {
                            SpecialtyId = "3001.04.01",
                            DepartmentId = "3001-DCP"
                        },
                        new
                        {
                            SpecialtyId = "3001.04.03",
                            DepartmentId = "3001-DCP"
                        },
                        new
                        {
                            SpecialtyId = "4001.04.01",
                            DepartmentId = "4001-DP"
                        },
                        new
                        {
                            SpecialtyId = "4001.04.04",
                            DepartmentId = "4001-DD"
                        },
                        new
                        {
                            SpecialtyId = "4002.04.02",
                            DepartmentId = "4002-DL"
                        },
                        new
                        {
                            SpecialtyId = "4003.04.03",
                            DepartmentId = "4003-DSP"
                        },
                        new
                        {
                            SpecialtyId = "5001.05.02",
                            DepartmentId = "5001-DL"
                        },
                        new
                        {
                            SpecialtyId = "5001.04.01",
                            DepartmentId = "5001-DL"
                        },
                        new
                        {
                            SpecialtyId = "6001.05.02",
                            DepartmentId = "6001-DI"
                        },
                        new
                        {
                            SpecialtyId = "6002.04.02",
                            DepartmentId = "6002-DSE"
                        },
                        new
                        {
                            SpecialtyId = "6003.04.02",
                            DepartmentId = "6003-DL"
                        },
                        new
                        {
                            SpecialtyId = "6004.04.02",
                            DepartmentId = "6004-DF"
                        },
                        new
                        {
                            SpecialtyId = "7001.03.02",
                            DepartmentId = "7001-DSP"
                        });
                });

            modelBuilder.Entity("EducationDepartment.Domain.Entity.Faculty", b =>
                {
                    b.Property<string>("FacultyId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NameFaculty")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("FacultyId");

                    b.HasIndex("RegistrationNumber");

                    b.ToTable("Faculty");

                    b.HasData(
                        new
                        {
                            FacultyId = "1001",
                            NameFaculty = "Faculty of Information Technology",
                            RegistrationNumber = "UNI001"
                        },
                        new
                        {
                            FacultyId = "1002",
                            NameFaculty = "Faculty of Mechanical Engineering",
                            RegistrationNumber = "UNI001"
                        },
                        new
                        {
                            FacultyId = "1003",
                            NameFaculty = "Faculty of Finance and Banking",
                            RegistrationNumber = "UNI001"
                        },
                        new
                        {
                            FacultyId = "1004",
                            NameFaculty = "Faculty of Translation",
                            RegistrationNumber = "UNI001"
                        },
                        new
                        {
                            FacultyId = "2001",
                            NameFaculty = "Faculty of Medicine",
                            RegistrationNumber = "UNI002"
                        },
                        new
                        {
                            FacultyId = "2002",
                            NameFaculty = "Faculty of Agronomy",
                            RegistrationNumber = "UNI002"
                        },
                        new
                        {
                            FacultyId = "3001",
                            NameFaculty = "Faculty of Pedagogye",
                            RegistrationNumber = "UNI003"
                        },
                        new
                        {
                            FacultyId = "4001",
                            NameFaculty = "Faculty of Fine Arts",
                            RegistrationNumber = "UNI004"
                        },
                        new
                        {
                            FacultyId = "4002",
                            NameFaculty = "Faculty of Translation",
                            RegistrationNumber = "UNI004"
                        },
                        new
                        {
                            FacultyId = "4003",
                            NameFaculty = "Faculty of Sports Science",
                            RegistrationNumber = "UNI004"
                        },
                        new
                        {
                            FacultyId = "5001",
                            NameFaculty = "Faculty of International Law",
                            RegistrationNumber = "UNI005"
                        },
                        new
                        {
                            FacultyId = "6001",
                            NameFaculty = "Faculty of Information Technology",
                            RegistrationNumber = "UNI006"
                        },
                        new
                        {
                            FacultyId = "6002",
                            NameFaculty = "Faculty of Pedagogye",
                            RegistrationNumber = "UNI006"
                        },
                        new
                        {
                            FacultyId = "6003",
                            NameFaculty = "Faculty of Translation",
                            RegistrationNumber = "UNI006"
                        },
                        new
                        {
                            FacultyId = "6004",
                            NameFaculty = "Faculty of Finance and Banking",
                            RegistrationNumber = "UNI006"
                        },
                        new
                        {
                            FacultyId = "7001",
                            NameFaculty = "Faculty of Sports Science",
                            RegistrationNumber = "UNI007"
                        });
                });

            modelBuilder.Entity("EducationDepartment.Domain.Entity.Specialty", b =>
                {
                    b.Property<string>("SpecialtyId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NameSpecialty")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfGroups")
                        .HasColumnType("int");

                    b.HasKey("SpecialtyId");

                    b.ToTable("Specialty");

                    b.HasData(
                        new
                        {
                            SpecialtyId = "1001.05.03",
                            NameSpecialty = "Computer Software Science",
                            NumberOfGroups = 7
                        },
                        new
                        {
                            SpecialtyId = "1001.04.03",
                            NameSpecialty = "Computer Science",
                            NumberOfGroups = 8
                        },
                        new
                        {
                            SpecialtyId = "1002.05.01",
                            NameSpecialty = "Mechanical Engineering",
                            NumberOfGroups = 10
                        },
                        new
                        {
                            SpecialtyId = "1002.04.02",
                            NameSpecialty = "Mechanical Collaboration",
                            NumberOfGroups = 5
                        },
                        new
                        {
                            SpecialtyId = "1003.04.05",
                            NameSpecialty = "Finance and Banking",
                            NumberOfGroups = 9
                        },
                        new
                        {
                            SpecialtyId = "1004.04.03",
                            NameSpecialty = "Translation Studies",
                            NumberOfGroups = 11
                        },
                        new
                        {
                            SpecialtyId = "2001.06.02",
                            NameSpecialty = "Doctor",
                            NumberOfGroups = 5
                        },
                        new
                        {
                            SpecialtyId = "2001.05.02",
                            NameSpecialty = "Medicine",
                            NumberOfGroups = 3
                        },
                        new
                        {
                            SpecialtyId = "2002.04.02",
                            NameSpecialty = "Agronomy",
                            NumberOfGroups = 4
                        },
                        new
                        {
                            SpecialtyId = "2002.04.04",
                            NameSpecialty = "Pedagogye",
                            NumberOfGroups = 6
                        },
                        new
                        {
                            SpecialtyId = "3001.04.01",
                            NameSpecialty = "Pedagogye",
                            NumberOfGroups = 8
                        },
                        new
                        {
                            SpecialtyId = "3001.04.03",
                            NameSpecialty = "Sports Science",
                            NumberOfGroups = 2
                        },
                        new
                        {
                            SpecialtyId = "4001.04.01",
                            NameSpecialty = "Fine Arts",
                            NumberOfGroups = 5
                        },
                        new
                        {
                            SpecialtyId = "4001.04.04",
                            NameSpecialty = "Beauty Arts",
                            NumberOfGroups = 6
                        },
                        new
                        {
                            SpecialtyId = "4002.04.02",
                            NameSpecialty = "Translation Studies",
                            NumberOfGroups = 6
                        },
                        new
                        {
                            SpecialtyId = "4003.04.03",
                            NameSpecialty = "Sports Science",
                            NumberOfGroups = 4
                        },
                        new
                        {
                            SpecialtyId = "5001.05.02",
                            NameSpecialty = "International Law",
                            NumberOfGroups = 3
                        },
                        new
                        {
                            SpecialtyId = "5001.04.01",
                            NameSpecialty = "Foreign Law",
                            NumberOfGroups = 5
                        },
                        new
                        {
                            SpecialtyId = "6001.05.02",
                            NameSpecialty = "Computer Software Science",
                            NumberOfGroups = 7
                        },
                        new
                        {
                            SpecialtyId = "6002.04.02",
                            NameSpecialty = "Pedagogye",
                            NumberOfGroups = 8
                        },
                        new
                        {
                            SpecialtyId = "6003.04.02",
                            NameSpecialty = "Translation Studies",
                            NumberOfGroups = 8
                        },
                        new
                        {
                            SpecialtyId = "6004.04.02",
                            NameSpecialty = "Finance and Banking",
                            NumberOfGroups = 5
                        },
                        new
                        {
                            SpecialtyId = "7001.03.02",
                            NameSpecialty = "Sports Science",
                            NumberOfGroups = 7
                        });
                });

            modelBuilder.Entity("EducationDepartment.Domain.Entity.University", b =>
                {
                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BuildingOwnership")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NameUniversity")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RectorFullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RegistrationNumber");

                    b.ToTable("University");

                    b.HasData(
                        new
                        {
                            RegistrationNumber = "UNI001",
                            Address = "34 Tech Street",
                            BuildingOwnership = "Federal",
                            Degree = "PhD",
                            NameUniversity = "University of Technology and Economics",
                            PropertyType = "Municipal",
                            RectorFullName = "Ivan Yefimovich Petrov",
                            Title = "Professor"
                        },
                        new
                        {
                            RegistrationNumber = "UNI002",
                            Address = "456 Health Road",
                            BuildingOwnership = "Private",
                            Degree = "Doctor",
                            NameUniversity = "Medical University",
                            PropertyType = "Private",
                            RectorFullName = "Anna Ivanova Vladimirovna",
                            Title = "Professor"
                        },
                        new
                        {
                            RegistrationNumber = "UNI004",
                            Address = "654 Art Boulevard",
                            BuildingOwnership = "Private",
                            Degree = "MA",
                            NameUniversity = "University of Arts",
                            PropertyType = "Private",
                            RectorFullName = "Marina Vasilievna Smirnova",
                            Title = "Associate Professor"
                        },
                        new
                        {
                            RegistrationNumber = "UNI003",
                            Address = "321 Education Street",
                            BuildingOwnership = "Municipal",
                            Degree = "PhD",
                            NameUniversity = "Pedagogical University",
                            PropertyType = "Municipal",
                            RectorFullName = "Olga Petrova",
                            Title = "Professor"
                        },
                        new
                        {
                            RegistrationNumber = "UNI005",
                            Address = "852 Justice Boulevard",
                            BuildingOwnership = "Municipal",
                            Degree = "PhD",
                            NameUniversity = "Law University",
                            PropertyType = "Private",
                            RectorFullName = "Nikolai Vasilyevich Sergeev",
                            Title = "Professor"
                        },
                        new
                        {
                            RegistrationNumber = "UNI006",
                            Address = "741 Pology Street",
                            BuildingOwnership = "Municipal",
                            Degree = "PhD",
                            NameUniversity = "University of Foreign Languages",
                            PropertyType = "Municipal",
                            RectorFullName = "Tatiana Nikolaevna Fedorova",
                            Title = "Professor"
                        },
                        new
                        {
                            RegistrationNumber = "UNI007",
                            Address = "963 Lenin Prospekt",
                            BuildingOwnership = "Federal",
                            Degree = "PhD",
                            NameUniversity = "Sports University",
                            PropertyType = "Municipal",
                            RectorFullName = "Sergey Sergeevich Kozlov",
                            Title = "Professor"
                        });
                });

            modelBuilder.Entity("EducationDepartment.Domain.Entity.Department", b =>
                {
                    b.HasOne("EducationDepartment.Domain.Entity.Faculty", null)
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationDepartment.Domain.Entity.DepartmentSpecialty", b =>
                {
                    b.HasOne("EducationDepartment.Domain.Entity.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationDepartment.Domain.Entity.Specialty", null)
                        .WithMany()
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationDepartment.Domain.Entity.Faculty", b =>
                {
                    b.HasOne("EducationDepartment.Domain.Entity.University", null)
                        .WithMany()
                        .HasForeignKey("RegistrationNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
