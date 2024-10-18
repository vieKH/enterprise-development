﻿namespace EducationDepartment.API.Services;

/// <summary>
/// Interface for object's service
/// </summary>
/// <typeparam name="T">Generic Type</typeparam>
public interface IService<T>
{
    /// <summary>
    /// Get list of T
    /// </summary>
    /// <returns>List of T</returns>
    public IEnumerable<T> GetAll();

    /// <summary>
    /// Get infomation about one T object by id
    /// </summary>
    /// <param name="id">id</param>
    /// <returns>Object's information or null</returns>
    public T? GetById(string id);

    /// <summary>
    /// Post object's information to database
    /// </summary>
    /// <param name="dtoData"></param>
    public void Post(T dtoData);

    /// <summary>
    /// Correct object's information by id
    /// </summary>
    /// <param name="dtoData">Object's information</param>
    /// <returns>True or False</returns>
    public bool Put(T dtoData);

    /// <summary>
    /// Delete 1 object T in list by id
    /// </summary>
    /// <param name="id">id</param>
    /// <returns>True or False</returns>
    public bool Delete(string id);
}
