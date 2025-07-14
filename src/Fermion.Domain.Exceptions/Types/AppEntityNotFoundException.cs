namespace Fermion.Domain.Exceptions.Types;

/// <summary>
/// Represents an exception that occurs when an entity is not found in the database.
/// </summary>
public class AppEntityNotFoundException : AppException
{
    public override string Code { get; set; } = "APP:ENTITY:1000";
    public override string? Details { get; set; } = "The requested entity was not found in the database.";
    public override int StatusCode { get; set; } = 404;
    public Type? EntityType { get; set; }
    public object? Id { get; set; }

    public AppEntityNotFoundException() : base("Entity not found.")
    {
    }

    public AppEntityNotFoundException(string message) : base(message)
    {
    }

    public AppEntityNotFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public AppEntityNotFoundException(Type entityType) : this(entityType, null, null)
    {
    }

    public AppEntityNotFoundException(Type entityType, object? id) : this(entityType, id, null)
    {
    }

    public AppEntityNotFoundException(Type entityType, object? id = null, Exception? innerException = null)
        : base(
            id == null
                ? $"There is no such an entity given id. Entity type: {entityType.FullName}"
                : $"There is no such an entity. Entity type: {entityType.FullName}, id: {id}",
            innerException)
    {
        EntityType = entityType;
        Id = id;
    }
}