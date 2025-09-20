using System.Net;
using System.Net.Http.Json;
using ToennVaot.Components.Core.Api.Models;

namespace ToennVaot.Components.Core.Api.Extensions
{
    /// <summary>
    /// The extensions for HttpResponseMessage
    /// </summary>
    public static class HttpResponseMessageExtensions
    {
        /// <summary>
        /// Throws an HttpRequestException if the response status code does not indicate success.
        /// </summary>
        /// <param name="response">The HTTP response message</param>
        public static void EnsureSuccessStatusCodeAndPropagate(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode) return;
            
            if (!response.IsSuccessStatusCode)
            {
                switch (response.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        var model = response.Content.ReadFromJsonAsync<BadRequestModel>().Result ?? new BadRequestModel{ Errors =
                            [
                                new()
                                {
                                    Code = "99-999", Key = "global",
                                    Message = "The content of the error can't be retrieved"
                                }
                            ]
                        };
                        var exception = new HttpRequestException("", null, response.StatusCode);
                        model.Errors.ForEach(x => exception.Data.Add(x.Key, x.Code));
                        throw exception;
                    default:
                        response.EnsureSuccessStatusCode();
                        break;
                }
            }
        }
    }
}
