using System.Text;
using Microsoft.AspNetCore.Mvc;
using ToennVaot.Components.Core.Web.Models.Communication;

namespace ToennVaot.Components.Core.Web.ActionResults
{
    /// <summary>
    /// Represents the result of an action method which want to render a <see cref="VCalendar"/> object
    /// </summary>
    public class VCalendarResult : IActionResult
    {
        private const string ContentType = "text/vcalendar";

        private VCalendar EventCalendar { get; }

        /// <summary>
        /// Constructor with defined <paramref name="eventCalendar"/>
        /// </summary>
        /// <param name="eventCalendar">The <see cref="VCalendar"/> to render</param>
        public VCalendarResult(VCalendar eventCalendar)
        {
            EventCalendar = eventCalendar;
        }
        
        /// <inheritdoc />
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = ContentType;

            var filename = string.IsNullOrWhiteSpace(EventCalendar.Filename) ? string.IsNullOrWhiteSpace(EventCalendar.Event.Summary) ? "Event" : EventCalendar.Event.Summary : EventCalendar.Filename;
            response.Headers.Add("Content-Disposition", "attachment; fileName=" + filename + ".ics");

            var eventCalendarString = EventCalendar.ToString();
            var inputEncoding = Encoding.Default;
            var outputEncoding = Encoding.GetEncoding("windows-1257");
            var cardBytes = inputEncoding.GetBytes(eventCalendarString);
            var outputBytes = Encoding.Convert(inputEncoding, outputEncoding, cardBytes);

            await response.Body.WriteAsync(outputBytes, 0, outputBytes.Length);
        }
    }
}