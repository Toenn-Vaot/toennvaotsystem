using CsvHelper;
using System.Globalization;
using System.Text;

namespace ToennVaot.Components.Core
{
    /// <summary>
    /// The Extensions constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Security constants
        /// </summary>
        public static class Security
        {
            /// <summary>
            /// Authentication claim constants
            /// </summary>
            public static class ClaimType
            {
                /// <summary>
                /// The grant type claim name
                /// </summary>
                public const string GrantType = "gt";

                /// <summary>
                /// The client identifier claim type
                /// </summary>
                public const string CustomerId = "customer_id";
            }

            /// <summary>
            /// Request header constants
            /// </summary>
            public static class RequestHeader
            {
                /// <summary>
                /// Header string name to specify the request should be impersonated
                /// </summary>
                public const string ViewAs = "ViewAs";
            }
        }
    }
}
