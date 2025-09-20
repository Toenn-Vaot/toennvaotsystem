using System.Text.Json.Serialization;
using ToennVaot.Components.Core.Models.Countries;

namespace ToennVaot.Components.Core.Models
{
    /// <summary>
    /// This class describes a postal address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// The street number
        /// </summary>
        [JsonPropertyName("number")]
        public int StreetNumber { get; set; }
        
        /// <summary>
        /// The street number suffix
        /// </summary>
        [JsonPropertyName("numberSuffix")]
        public char StreetNumberSuffix { get; set; }

        /// <summary>
        /// The street name
        /// </summary>
        [JsonPropertyName("street")]
        public string StreetName { get; set; }

        /// <summary>
        /// The shorten version of street name
        /// </summary>
        [JsonPropertyName("shortenStreet")]
        public string ShortenStreetName { get; set; }

        /// <summary>
        /// The complement of street adding more details about the localization (house name, ...)
        /// </summary>
        [JsonPropertyName("complementStreet")]
        public string ComplementStreet { get; set; }

        /// <summary>
        /// The postal code
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The city name
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// The region name
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// The two letters iso code of the country
        /// </summary>
        [JsonPropertyName("countryIsoCode")]
        public string CountryIsoCode2 { get; set; }

        /// <summary>
        /// The country instance
        /// </summary>
        [JsonPropertyName("country")]
        public Country Country { get; set; }
    }
}
