namespace ToennVaot.Components.Core.Stores
{
    /// <summary>
    /// The store base options
    /// </summary>
    public class StoreBaseOptions
    {
        /// <summary>
        /// The connection string
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// The host name
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// The instance name
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// The username
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// The password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The database name
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Flag indicating if the connection should be secure
        /// </summary>
        public bool Secure { get; set; }
    }
}
