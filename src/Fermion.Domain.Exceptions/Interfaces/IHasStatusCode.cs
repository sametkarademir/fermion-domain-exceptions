namespace Fermion.Domain.Exceptions.Interfaces;

/// <summary>
/// Interface for objects that have a status code.
/// </summary>
public interface IHasStatusCode
{
    /// <summary>
    /// Gets the status code associated with the object.
    /// </summary>
    int StatusCode { get; }
}