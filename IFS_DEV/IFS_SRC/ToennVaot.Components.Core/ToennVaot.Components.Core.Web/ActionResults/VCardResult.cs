using System.Text;
using Microsoft.AspNetCore.Mvc;
using ToennVaot.Components.Core.Web.Models.Communication;

namespace ToennVaot.Components.Core.Web.ActionResults
{
    /// <summary>
    /// Represents the result of an action method which want to render a <see cref="VCard"/> object
    /// </summary>
    public class VCardResult : IActionResult
    {
        private const string ContentType = "text/vcard";

        private VCard Card { get; }

        /// <summary>
        /// Constructor with defined <paramref name="card"/>
        /// </summary>
        /// <param name="card">The <see cref="VCard"/> to render</param>
        public VCardResult(VCard card)
        {
            Card = card;
        }

        /// <inheritdoc />
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = ContentType;
            response.Headers.Add("Content-Disposition", "attachment; fileName=" + Card.FirstName + "_" + Card.LastName + ".vcf");

            var cardString = Card.ToString();
            var inputEncoding = Encoding.Default;
            var outputEncoding = Encoding.GetEncoding("windows-1257");
            var cardBytes = inputEncoding.GetBytes(cardString);
            var outputBytes = Encoding.Convert(inputEncoding, outputEncoding, cardBytes);

            await response.Body.WriteAsync(outputBytes, 0, outputBytes.Length);
        }
    }
}