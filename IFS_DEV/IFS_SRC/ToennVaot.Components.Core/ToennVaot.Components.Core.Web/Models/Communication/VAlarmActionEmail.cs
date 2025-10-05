using System.Text;

namespace ToennVaot.Components.Core.Web.Models.Communication
{
    /// <summary>
    /// Represents a <see cref="VAlarmAction"/> which send an email
    /// </summary>
    public class VAlarmActionEmail : VAlarmAction
    {
        /// <summary>
        /// The email address of recipient
        /// </summary>
        public string AttendeeEmail { get; set; }

        /// <summary>
        /// The summary of the email (~ subject)
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// The description of the email (~ body content)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructor defines the name of <see cref="VAlarmAction"/>
        /// </summary>
        public VAlarmActionEmail()
        {
            Name = "EMAIL";
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var builder = new StringBuilder(base.ToString());
            builder.AppendLine("ATTENDEE:MAILTO" + AttendeeEmail);
            builder.AppendLine("SUMMARY:" + Summary);
            builder.AppendLine("DESCRIPTION:" + Description);
            return builder.ToString();
        }
    }
}