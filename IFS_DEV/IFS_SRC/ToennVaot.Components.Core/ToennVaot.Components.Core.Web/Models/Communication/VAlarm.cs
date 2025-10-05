using System.Text;

namespace ToennVaot.Components.Core.Web.Models.Communication
{
    /// <summary>
    /// Represents an alarm will execute a <see cref="VAlarmAction"/> on trigger
    /// </summary>
    public class VAlarm
    {
        /// <summary>
        /// The delay when the alarm must start
        /// </summary>
        public TimeSpan AlertDelayBefore { get; set; }

        /// <summary>
        /// The number of repeat the trigger will be done
        /// </summary>
        public int RepeatCount { get; set; }

        /// <summary>
        /// The delay between each repeat
        /// </summary>
        public TimeSpan RepeatInterval { get; set; }

        /// <summary>
        /// The <see cref="VAlarmAction"/> to execute when alarm is triggered
        /// </summary>
        /// <seealso cref="VAlarmActionDisplay"/>
        /// <seealso cref="VAlarmActionEmail"/>
        public VAlarmAction Action { get; set; }

        private string AlertDelayBeforeString
        {
            get
            {
                if (AlertDelayBefore.Days > 0)
                    return "T" + AlertDelayBefore.Days + "D";
                return "T" + AlertDelayBefore.TotalMinutes + "M";
            }
        }

        private string RepeatIntervalString
        {
            get
            {
                if (RepeatInterval.Days > 0)
                    return "T" + RepeatInterval.Days + "D";
                return "T" + RepeatInterval.TotalMinutes + "M";
            }
        }

        /// <summary>
        /// Returns a string represents the object
        /// </summary>
        /// <returns>The VAlarm content like it is defined in the reference of vCalendar format</returns>
        /// <remarks>It is used here also to get the content of an alarm for vCalendar file</remarks>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("BEGIN:VALARM");
            //Trigger
            builder.AppendLine("TRIGGER:-P" + AlertDelayBeforeString);
            //Repeat
            if (RepeatCount > 0)
            {
                builder.AppendLine("REPEAT:" + RepeatCount);
                builder.AppendLine("DURATION:" + RepeatIntervalString);
            }
            //Action
            builder.AppendLine(Action.ToString());
            builder.AppendLine("END:VALARM");
            return builder.ToString();
        }
    }
}