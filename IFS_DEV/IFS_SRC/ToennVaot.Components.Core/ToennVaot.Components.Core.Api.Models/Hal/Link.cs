using Newtonsoft.Json;

namespace ToennVaot.Components.Core.Api.Models.Hal
{
    /// <summary>
    /// This class represents a link which determined which resource is available from the called request.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// The hypertext reference value
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }
        
        /// <summary>
        /// The relation
        /// </summary>
        [JsonProperty("rel")]
        public string Rel { get; set; }
        
        /// <summary>
        /// The link name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The HTTP method
        /// </summary>
        [JsonIgnore]
        public HttpMethod Method { get; set; }

        /// <summary>
        /// The HTTP method
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpMethod => Method?.Method;
    }
}
