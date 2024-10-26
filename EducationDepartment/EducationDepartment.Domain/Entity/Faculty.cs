﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationDepartment.Domain.Entity;

/// <summary>
/// Class for saving faculty's information
/// </summary>
public class Faculty
{
    /// <summary>
    /// Faculty's id
    /// </summary>
    [Key]
    public required string FacultyId { get; set; }

    /// <summary>
    /// Faculty's name
    /// </summary>
    public required string NameFaculty { get; set; }

    /// <summary>
    /// University registration number
    /// </summary>
    [ForeignKey("University")]
    public required string RegistrationNumber { get; set; }
}
