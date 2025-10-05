using System.Text;

namespace ToennVaot.Components.Core.Web.Models.Communication
{
    /// <summary>
    /// Represents a <see cref="VAlarmAction"/> which display a message
    /// </summary>
    public class VAlarmActionDisplay : VAlarmAction
    {
        /// <summary>
        /// The description of the action to display
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructor defines the name of <see cref="VAlarmAction"/>
        /// </summary>
        public VAlarmActionDisplay()
        {
            Name = "DISPLAY";
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.AppendLine("DESCRIPTION:" + Description);
            return builder.ToString();
        }
    }
}