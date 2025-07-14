using Fermion.Domain.Exceptions.Interfaces;
using Fermion.Domain.Exceptions.Models;

namespace Fermion.Domain.Exceptions.Types;

/// <summary>
/// Represents an exception that occurs when validation fails in the application.
/// </summary>
public class AppValidationException : AppException, IHasValidationErrors
{
    public override string Code { get; set; } = "APP:VALIDATION:1000";
    public override string? Details { get; set; } = "One or more validation errors occurred. Please check the provided data.";
    public override int StatusCode { get; set; } = 400;
    public IEnumerable<ValidationExceptionModel> Errors { get; }

    public AppValidationException() : base("Validation error")
    {
        Errors = Array.Empty<ValidationExceptionModel>();
    }

    public AppValidationException(string message) : base(message)
    {
        Errors = Array.Empty<ValidationExceptionModel>();
    }

    public AppValidationException(string message, Exception innerException) : base(message, innerException)
    {
        Errors = Array.Empty<ValidationExceptionModel>();
    }

    public AppValidationException(IEnumerable<ValidationExceptionModel> errors) : base(BuildErrorMessage(errors))
    {
        Errors = errors;
    }

    private static string BuildErrorMessage(IEnumerable<ValidationExceptionModel> errors)
    {
        var arr = errors.Select(x =>
            $"{Environment.NewLine} -- {x.Property}: {string.Join(Environment.NewLine, values: x.Errors ?? Array.Empty<string>())}"
        );

        return string.Join(string.Empty, arr);
    }
}