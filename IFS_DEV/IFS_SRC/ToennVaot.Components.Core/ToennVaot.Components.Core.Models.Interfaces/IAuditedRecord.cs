namespace ToennVaot.Components.Core.Models.Interfaces;

/// <summary>
/// Interface defines an audited record
/// </summary>
public interface IAuditedRecord<T>
{
    /// <summary>
    /// The date and time when the record was created
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// The identifier who created the record
    /// </summary>
    public T CreatedBy { get; set; }

    /// <summary>
    /// The date and time when the record was last updated
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// The identifier who last updated the record
    /// </summary>
    public T UpdatedBy { get; set; }
}