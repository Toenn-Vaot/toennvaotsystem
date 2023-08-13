using Newtonsoft.Json;

namespace ToennVaot.Components.Core.Api.Models.Hal
{
    /// <summary>
    /// The representation base class to support HAL format
    /// </summary>
    public abstract class Representation
    {
        /// <summary>
        /// The related links
        /// </summary>
        [JsonProperty("_links")]
        [JsonIgnore]
        public Dictionary<string, Link> Links { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        protected Representation()
        {
            Links = new Dictionary<string, Link>();
        }
    }
}
