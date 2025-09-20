using Microsoft.Extensions.Logging;
using ToennVaot.Components.Core.Models;

namespace ToennVaot.Components.Core.Managers
{
    /// <summary>
    /// This is the base class for all managers
    /// </summary>
    public abstract class ManagerBase
    {
        /// <summary>
        /// The logger instance
        /// </summary>
        protected readonly ILogger Logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">The logger instance</param>
        protected ManagerBase(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Method to throw exceptions from a <see cref="StoreRequestResult"/> object.
        /// </summary>
        /// <param name="response">The <see cref="StoreRequestResult"/> object</param>
        public Exception ThrowExceptions<T>(StoreRequestResult<T> response)
        {
            return response.Exceptions.Count switch
            {
                1 => response.Exceptions.First(),
                > 1 => new AggregateException(response.Exceptions),
                _ => new InvalidOperationException("No exceptions were thrown, but the response was not successful.")
            };
        }
    }
}
