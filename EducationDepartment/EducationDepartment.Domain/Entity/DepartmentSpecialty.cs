﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationDepartment.Domain.Entity;

/// <summary>
/// Class for saving specialties in department
/// </summary>
public class DepartmentSpecialty
{
    /// <summary>
    /// Department's id
    /// </summary>
    [ForeignKey("Department")]
    public required string DepartmentId { get; set; }

    /// <summary>
    /// Faculty's id
    /// </summary>
    [Key]
    [ForeignKey("Specialty")]
    public required string SpecialtyId { get; set; }
}

