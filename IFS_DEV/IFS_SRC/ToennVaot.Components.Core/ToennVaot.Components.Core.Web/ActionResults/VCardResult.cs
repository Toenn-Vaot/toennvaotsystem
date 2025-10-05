using System.Text;
using Microsoft.AspNetCore.Mvc;
using ToennVaot.Components.Core.Web.Models.Communication;

namespace ToennVaot.Components.Core.Web.ActionResults
{
    /// <summary>
    /// Represents the result of an action method which want to render a <see cref="VCard"/> object
    /// </summary>
    public class VCardResult : ActionResult
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

        /// <summary>
        /// Enables processing of the result of an action method by a custom type that inherits from the <see cref="T:ActionResult"/> class.
        /// </summary>
        /// <param name="context">The context in which the result is executed. The context information includes the controller, HTTP content, request context, and route data.</param>
        public override void ExecuteResult(ActionContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = ContentType;
            response.Headers.Add("Content-Disposition", "attachment; fileName=" + Card.FirstName + "_" + Card.LastName + ".vcf");

            var cardString = Card.ToString();
            var inputEncoding = Encoding.Default;
            var outputEncoding = Encoding.GetEncoding("windows-1257");
            var cardBytes = inputEncoding.GetBytes(cardString);
            var outputBytes = Encoding.Convert(inputEncoding, outputEncoding, cardBytes);

            response.Body.Write(outputBytes, 0, outputBytes.Length);
        }
    }
}