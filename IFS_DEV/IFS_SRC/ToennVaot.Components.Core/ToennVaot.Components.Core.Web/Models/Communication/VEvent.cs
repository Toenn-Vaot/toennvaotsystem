using System.Text;

namespace ToennVaot.Components.Core.Web.Models.Communication
{
    /// <summary>
    /// Represents an event scheduled in a <see cref="VCalendar"/> file
    /// </summary>
    public class VEvent
    {
        /// <summary>
        /// The summary of the event
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// The detailed description of the event
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The location of the event
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The start date of the event
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the event
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Indicates if the event is for all day long
        /// </summary>
        public bool FullDayEvent { get; set; }

        /// <summary>
        /// The <see cref="VCalendarClassEnum"/> of the event
        /// </summary>
        public VCalendarClassEnum ClassEnum { get; set; }

        /// <summary>
        /// The priority of the event
        /// </summary>
        public VCalendarPriorityEnum PriorityEnum { get; set; }

        /// <summary>
        /// The <see cref="VAlarm"/> of the event
        /// </summary>
        public VAlarm Alarm { get; set; }

        /// <summary>
        /// Returns a string represents the object
        /// </summary>
        /// <returns>The VEvent content like it is defined in the reference of vCalendar format</returns>
        /// <remarks>It is used here also to get the content of an event for vCalendar file</remarks>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("BEGIN:VEVENT");
            builder.AppendLine("UID:" + DateTime.UtcNow.ToString("o") + "@host.com");
            builder.AppendLine("DTSTART:" + (FullDayEvent ? "VALUE=" + StartDate.ToString("yyyyMMdd") : StartDate.ToString("yyyyMMddTHHmmssZ")));
            builder.AppendLine("DTEND:" + (FullDayEvent ? "VALUE=" + EndDate.ToString("yyyyMMdd") : EndDate.ToString("yyyyMMddTHHmmssZ")));
            builder.AppendLine("SUMMARY:" + Summary);
            builder.AppendLine("LOCATION:" + Location);
            builder.AppendLine(ClassEnum.ToString());
            builder.AppendLine("DESCRIPTION:" + Description);
            if (Alarm != null)
                builder.AppendLine(Alarm.ToString());
            builder.AppendLine("END:VEVENT");
            return builder.ToString();
        }
    }
}