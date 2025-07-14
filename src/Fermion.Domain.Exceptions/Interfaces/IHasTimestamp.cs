namespace Fermion.Domain.Exceptions.Interfaces;

/// <summary>
/// Interface for objects that have a timestamp.
/// </summary>
public interface IHasTimestamp
{
    /// <summary>
    /// Gets the timestamp associated with the object.
    /// </summary>
    DateTime Timestamp { get; }
}