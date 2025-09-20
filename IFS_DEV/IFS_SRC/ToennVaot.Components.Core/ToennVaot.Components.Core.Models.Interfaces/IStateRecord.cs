namespace ToennVaot.Components.Core.Models.Interfaces;

/// <summary>
/// Interface defines a state record
/// </summary>
public interface IStateRecord<T>
{
    /// <summary>
    /// The status identifier
    /// </summary>
    public T StatusId { get; set; }

    /// <summary>
    /// The date and time when the status was last changed
    /// </summary>
    public DateTimeOffset? StateChangedAt { get; set; }

    /// <summary>
    /// The user who last changed the status
    /// </summary>
    public string StateChangedBy { get; set; }
}