namespace Fermion.Domain.Exceptions.Interfaces;

/// <summary>
/// Interface for objects that have error details.
/// </summary>
public interface IHasErrorDetails
{
    /// <summary>
    /// Gets the details of the error associated with the object.
    /// </summary>
    string? Details { get; }
}