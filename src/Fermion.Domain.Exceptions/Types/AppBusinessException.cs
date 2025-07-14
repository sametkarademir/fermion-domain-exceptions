namespace Fermion.Domain.Exceptions.Types;

/// <summary>
/// Represents an exception that occurs in the business logic of the application.
/// </summary>
public class AppBusinessException : AppException
{
    public override string Code { get; set; } = "APP:BUSINESS:1000";
    public override string? Details { get; set; } = "An error occurred in the business logic of the application.";
    public override int StatusCode { get; set; } = 500;

    public AppBusinessException() : base("A business logic error occurred")
    {
    }

    public AppBusinessException(string message) : base(message)
    {
    }

    public AppBusinessException(string message, Exception innerException) : base(message, innerException)
    {
    }
}