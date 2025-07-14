using Fermion.Domain.Exceptions.Interfaces;

namespace Fermion.Domain.Exceptions.Types;


/// <summary>
/// Represents a base exception for the application.
/// </summary>
public abstract class AppException :
    Exception,
    IHasCorrelationId,
    IHasErrorCode,
    IHasErrorDetails,
    IHasStatusCode,
    IHasTimestamp
{
    public virtual string? CorrelationId { get; set; }
    public virtual string Code { get; set; } = "APP:GENERAL:1000";
    public virtual string? Details { get; set; } = "An error occurred in the application.";
    public virtual int StatusCode { get; set; } = 500;
    public virtual DateTime Timestamp { get; set; } = DateTime.UtcNow;

    protected AppException() : base("An error occurred in the application.")
    {
    }

    protected AppException(string? message) : base(message)
    {
    }

    protected AppException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Adds a key-value pair to the exception's data dictionary.
    /// </summary>
    /// <param name="name">The key for the data item.</param>
    /// <param name="value">The value for the data item.</param>
    /// <returns>Returns the current instance of the exception.</returns>
    public AppException WithData(string name, object value)
    {
        Data[name] = value;
        return this;
    }

    /// <summary>
    /// Appends a dictionary of key-value pairs to the exception's data dictionary.
    /// </summary>
    /// <param name="data">The dictionary containing key-value pairs to append.</param>
    /// <returns>Returns the current instance of the exception.</returns>
    public AppException AppendData(IDictionary<string, object> data)
    {
        if (data.Count == 0)
        {
            return this;
        };

        foreach (var kvp in data)
        {
            Data[kvp.Key] = kvp.Value;
        }

        return this;
    }

    /// <summary>
    /// Sets the error code for the exception.
    /// </summary>
    /// <param name="code">The error code to set.</param>
    /// <returns>Returns the current instance of the exception.</returns>
    public AppException WithCode(string code)
    {
        Code = code;
        return this;
    }

    /// <summary>
    /// Sets the details for the exception.
    /// </summary>
    /// <param name="details">The details to set.</param>
    /// <returns>Returns the current instance of the exception.</returns>
    public AppException WithDetails(string details)
    {
        Details = details;
        return this;
    }

    /// <summary>
    /// Sets the status code for the exception.
    /// </summary>
    /// <param name="statusCode">The status code to set.</param>
    /// <returns>Returns the current instance of the exception.</returns>
    public AppException WithStatusCode(int statusCode)
    {
        StatusCode = statusCode;
        return this;
    }

    /// <summary>
    /// Sets the correlation ID for the exception.
    /// </summary>
    /// <param name="correlationId">The correlation ID to set.</param>
    /// <returns>Returns the current instance of the exception.</returns>
    public AppException WithCorrelationId(string correlationId)
    {
        CorrelationId = correlationId;
        return this;
    }
}