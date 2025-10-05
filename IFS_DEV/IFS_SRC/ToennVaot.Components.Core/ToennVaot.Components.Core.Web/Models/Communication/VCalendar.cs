using System.Text;

namespace ToennVaot.Components.Core.Web.Models.Communication
{
    /// <summary>
    /// Represents an electronic business card.
    /// </summary>
    /// <remarks>vCalendar is a standard format of personal data exchange which is normalized by RFC 5545</remarks>
    public class VCalendar
    {
        /// <summary>
        /// The <see cref="VEvent"/> scheduled
        /// </summary>
        public VEvent Event { get; set; }

        /// <summary>
        /// The file name represents the object
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Returns a string represents the object
        /// </summary>
        /// <returns>The vCalendar file content like it is defined in the reference of vCalendar format</returns>
        /// <remarks>It is used here also to get the content of a vCalendar file</remarks>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("BEGIN:VCALENDAR");
            builder.AppendLine("VERSION:2.0");
            builder.AppendLine("PRODID:-//hacksw/handcal//NONSGML v1.0//EN");
            builder.AppendLine(Event.ToString());
            builder.AppendLine("END:VCALENDAR");
            return builder.ToString();
        }
    }
}