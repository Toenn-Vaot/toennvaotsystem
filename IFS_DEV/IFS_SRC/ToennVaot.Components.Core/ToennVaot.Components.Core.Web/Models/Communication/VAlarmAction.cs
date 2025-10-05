namespace ToennVaot.Components.Core.Web.Models.Communication
{
    /// <summary>
    /// Represents a action to execute when <see cref="VAlarm"/> is executed
    /// </summary>
    /// <seealso cref="VAlarmActionDisplay"/>
    /// <seealso cref="VAlarmActionEmail"/>
    public abstract class VAlarmAction
    {
        /// <summary>
        /// The name of action
        /// </summary>
        protected string Name { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return "ACTION:" + Name;
        }
    }
}