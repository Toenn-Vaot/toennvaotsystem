 using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ToennVaot.Components.Core.Interfaces;

namespace ToennVaot.Components.Core.Stores
{
    /// <summary>
    /// The store base class
    /// </summary>
    public abstract class StoreBase<T, TU> : IStorageManager<T, TU>
        where T : DbConnection, new()
        where TU : DbTransaction
    {
        /// <summary>
        /// The base options to configure store
        /// </summary>
        protected StoreBaseOptions Options { get; set; }

        /// <summary>
        /// The base logger
        /// </summary>
        protected ILogger Logger { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options">The store base options instance</param>
        /// <param name="logger">The logger instance</param>
        protected StoreBase(IOptions<StoreBaseOptions> options, ILogger logger)
        {
            Options = options.Value;
            Logger = logger;
        }

        /// <inheritdoc />
        public virtual T GetConnection()
        {
            return new T { ConnectionString = Options.ConnectionString };
        }

        /// <inheritdoc />
        public virtual Tuple<T, TU> GetConnectionWithTransaction()
        {
            var connection = new T { ConnectionString = Options.ConnectionString };
            var transaction = (TU)connection.BeginTransaction();
            return new Tuple<T, TU> (connection, transaction);
        }
    }

    /// <summary>
    /// The store base class
    /// </summary>
    public abstract class StoreBase<T> : IStorageManager<T>
        where T : DbContext, new()
    {
        /// <summary>
        /// The base options to configure store
        /// </summary>
        protected StoreBaseOptions Options { get; set; }

        /// <summary>
        /// The base logger
        /// </summary>
        protected ILogger Logger { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">The database context instance</param>
        /// <param name="options">The store base options instance</param>
        /// <param name="logger">The logger instance</param>
        protected StoreBase(T context, IOptions<StoreBaseOptions> options, ILogger logger)
        {
            Context = context;
            Options = options.Value;
            Logger = logger;
        }

        /// <inheritdoc />
        public T Context { get; }
    }
}
