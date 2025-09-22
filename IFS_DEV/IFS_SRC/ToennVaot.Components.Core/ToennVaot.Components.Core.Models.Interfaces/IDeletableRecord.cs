namespace ToennVaot.Components.Core.Models.Interfaces;

/// <summary>
/// Interface defines a deletable record
/// </summary>
/// <typeparam name="TUser">The type to use to designate the user operating the actions</typeparam>
public interface IDeletableRecord<TUser>
{
    /// <summary>
    /// The date and time when the record was deleted
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <summary>
    /// The identifier who deleted the record
    /// </summary>
    public TUser DeletedBy { get; set; }
}