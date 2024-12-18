﻿using System.ComponentModel.DataAnnotations;

namespace EducationDepartment.Domain.Entity;

/// <summary>
/// Class for saving university's information
/// </summary>
public class University
{
    /// <summary>
    /// University's registration number
    /// </summary>
    [Key]
    public required string RegistrationNumber { get; set; }

    /// <summary>
    /// University's name
    /// </summary>
    public required string NameUniversity { get; set; }

    /// <summary>
    /// University's address
    /// </summary>
    public required string Address { get; set; }

    /// <summary>
    /// University's property type
    /// </summary>
    public required string PropertyType { get; set; }

    /// <summary>
    /// University's building owner
    /// </summary>
    public required string BuildingOwnership { get; set; }

    /// <summary>
    /// Rector's name
    /// </summary>
    public required string RectorFullName { get; set; }

    /// <summary>
    /// Rector's degree
    /// </summary>
    public required string Degree { get; set; }

    /// <summary>
    /// Rector's tittle
    /// </summary>
    public required string Title { get; set; }
}
