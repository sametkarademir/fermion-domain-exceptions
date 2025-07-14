namespace Fermion.Domain.Exceptions.Models;

/// <summary>
/// Represents a model for validation exceptions.
/// </summary>
public class ValidationExceptionModel
{
    /// <summary>
    /// Gets or sets the name of the property that caused the validation error.
    /// </summary>
    public string? Property { get; set; }

    /// <summary>
    /// Gets or sets the error message associated with the validation failure.
    /// </summary>
    public IEnumerable<string>? Errors { get; set; }
}