namespace Fermion.Domain.Exceptions.Types;


/// <summary>
/// Represents an exception that occurs when a user is not authorized to access a resource.
/// </summary>
public class AppAuthorizationException : AppException
{
    public override string Code { get; set; } = "APP:AUTHORIZATION:1000";
    public override string? Details { get; set; } = "Unauthorized request. You do not have permission to access this resource.";
    public override int StatusCode { get; set; } = 403;

    public AppAuthorizationException() : base("Unauthorized request.")
    {
    }

    public AppAuthorizationException(string message) : base(message)
    {

    }

    public AppAuthorizationException(string message, Exception innerException) : base(message, innerException)
    {

    }
}