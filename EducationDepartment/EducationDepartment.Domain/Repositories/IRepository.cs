﻿namespace EducationDepartment.Domain.Repositories;

/// <summary>
/// Interface for object's repository
/// </summary>
/// <typeparam name="T">Generic type</typeparam>
public interface IRepository<T>
{
    /// <summary>
    /// Method get list of objects T
    /// </summary>
    /// <returns>List of objects T</returns>
    public IEnumerable<T> GetAll();

    /// <summary>
    /// Method find object's information by id
    /// </summary>
    /// <param name="id">id</param>
    /// <returns>Object's information or null</returns>
    public T? GetById(string id);

    /// <summary>
    /// Method post object T to database
    /// </summary>
    /// <param name="data">Object's information</param>
    public void Post(T data);

    /// <summary>
    /// Method correct object's information by id in data
    /// </summary>
    /// <param name="data">Object's information</param>
    /// <returns></returns>
    public bool Put(T data);

    public bool Delete(string id);
}
