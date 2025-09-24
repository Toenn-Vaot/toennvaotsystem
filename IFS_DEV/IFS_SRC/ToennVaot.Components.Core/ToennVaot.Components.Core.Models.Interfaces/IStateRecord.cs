namespace ToennVaot.Components.Core.Models.Interfaces;

/// <summary>
/// The base interface for state records
/// </summary>
public interface IStateRecord<TUser>
{
    /// <summary>
    /// The status identifier
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// The date and time when the status was last changed
    /// </summary>
    public DateTimeOffset? StateChangedAt { get; set; }

    /// <summary>
    /// The user who last changed the status
    /// </summary>
    public TUser StateChangedBy { get; set; }
}

/// <summary>
/// Interface defines a state record
/// </summary>
/// <typeparam name="TState">The enumeration of states to apply</typeparam>
/// <typeparam name="TUser">The type to use to designate the user operating the actions</typeparam>
public interface IStateRecord<TState, TUser> : IStateRecord<TUser>
    where TState : struct, Enum
{
    /// <summary>
    /// The status identifier
    /// </summary>
    public TState Status { get; set; }
}