namespace ToennVaot.Components.Core
{
    /// <summary>
    /// The Extensions constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Languages constants
        /// </summary>
        public static class Languages
        {
            /// <summary>
            /// ISO language code for Danish (Denmark)
            /// </summary>
            public const string Danish = "da-DK";
            /// <summary>
            /// ISO language code for English (United Kingdom)
            /// </summary>
            public const string English = "en-GB";
            /// <summary>
            /// ISO language code for French (France)
            /// </summary>
            public const string French = "fr-FR";
        }

        /// <summary>
        /// Countries constants
        /// </summary>
        public static class Countries
        {
            /// <summary>
            /// Denmark country
            /// </summary>
            public const string Denmark = "DK";

            /// <summary>
            /// Denmark country
            /// </summary>
            public const string France = "FR";
        }

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
                /// Header string name to specify the request should be impersonate
                /// </summary>
                public const string ViewAs = "ViewAs";
            }
        }
    }
}
