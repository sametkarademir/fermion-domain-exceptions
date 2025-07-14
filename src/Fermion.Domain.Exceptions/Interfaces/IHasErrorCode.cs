namespace Fermion.Domain.Exceptions.Interfaces;

/// <summary>
/// Interface for objects that have an error code.
/// </summary>
public interface IHasErrorCode
{
    /// <summary>
    /// Gets the error code associated with the object.
    /// </summary>
    string? Code { get; }
}