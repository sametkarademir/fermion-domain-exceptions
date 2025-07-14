namespace Fermion.Domain.Exceptions.Interfaces;

/// <summary>
/// Interface for objects that have a correlation ID.
/// </summary>
public interface IHasCorrelationId
{
    /// <summary>
    /// Gets the correlation ID associated with the object.
    /// </summary>
    string? CorrelationId { get; }
}