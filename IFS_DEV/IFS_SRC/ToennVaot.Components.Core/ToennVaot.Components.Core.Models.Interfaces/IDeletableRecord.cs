namespace ToennVaot.Components.Core.Models.Interfaces;

/// <summary>
/// Interface defines a deletable record
/// </summary>
public interface IDeletableRecord<T>
{
    /// <summary>
    /// The date and time when the record was deleted
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <summary>
    /// The identifier who deleted the record
    /// </summary>
    public T DeletedBy { get; set; }
}