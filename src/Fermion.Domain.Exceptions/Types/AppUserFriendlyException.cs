namespace Fermion.Domain.Exceptions.Types;

/// <summary>
/// Represents an exception that is user-friendly and can be displayed to the end user.
/// </summary>
public class AppUserFriendlyException : AppException
{
    public override string Code { get; set; } = "APP:USERFRIENDLY:1000";
    public override string? Details { get; set; } = "An error occurred that is user-friendly and can be displayed to the end user.";
    public override int StatusCode { get; set; } = 400;

    public AppUserFriendlyException() : base("A user-friendly error occurred")
    {
    }

    public AppUserFriendlyException(string message) : base(message)
    {
    }

    public AppUserFriendlyException(string message, Exception innerException) : base(message, innerException)
    {
    }
}