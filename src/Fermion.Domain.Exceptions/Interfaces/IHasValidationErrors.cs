using Fermion.Domain.Exceptions.Models;

namespace Fermion.Domain.Exceptions.Interfaces;

/// <summary>
/// Interface for objects that have validation errors.
/// </summary>
public interface IHasValidationErrors
{
    /// <summary>
    /// Gets the collection of validation errors associated with the object.
    /// </summary>
    IEnumerable<ValidationExceptionModel> Errors { get; }
}