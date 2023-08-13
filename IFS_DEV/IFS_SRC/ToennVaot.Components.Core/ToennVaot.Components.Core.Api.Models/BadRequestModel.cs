using Newtonsoft.Json;

namespace ToennVaot.Components.Core.Api.Models
{
    /// <summary>
    /// This class describes the model for the errors description returned by a BadRequest in RestApi
    /// </summary>
    public class BadRequestModel
    {
        /// <summary>
        /// The requested uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// The error list
        /// </summary>
        [JsonProperty("errors")]
        public List<ErrorModel> Errors { get; set; }
    }
}
