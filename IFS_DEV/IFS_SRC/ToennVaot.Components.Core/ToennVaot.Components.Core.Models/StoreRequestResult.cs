﻿namespace ToennVaot.Components.Core.Models
{
    /// <summary>
    /// Defines the default store request object
    /// </summary>
    /// <remarks>Result object is boolean value</remarks>
    public class StoreRequestResult : StoreRequestResult<bool>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="result">The result flag</param>
        public StoreRequestResult(bool result)
        {
            Result = result;
        }
    }

    /// <summary>
    /// Defines the store request result object
    /// </summary>
    /// <typeparam name="T">The store result object type</typeparam>
    public class StoreRequestResult<T>
    {
        /// <summary>
        /// The result object of the operation.
        /// </summary>
        public T Result { get; set; } = default!;

        /// <summary>
        /// The list of exceptions occurred during operation.
        /// </summary>
        public List<Exception> Exceptions { get; set; } = new List<Exception>();

        /// <summary>
        /// Flag indicating whether if the operation succeeded or not.
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// Returns an <see cref="StoreRequestResult{T}"/> indicating a successful operation.
        /// </summary>
        /// <param name="result">The result content</param>
        /// <returns>An <see cref="StoreRequestResult{T}"/> indicating a success operation</returns>
        public static StoreRequestResult<T> Succeed(T result)
        {
            return new StoreRequestResult<T> { Result = result, Succeeded = true };
        }

        /// <summary>
        /// Creates an <see cref="StoreRequestResult{T}"/> indicating a failed operation, with a list of <paramref name="exceptions"/> if applicable.
        /// </summary>
        /// <param name="result">The result content</param>
        /// <param name="exceptions">An optional array of <see cref="Exception"/>s which caused the operation to fail.</param>
        /// <returns>An <see cref="StoreRequestResult{T}"/> indicating a failed operation, with a list of <paramref name="exceptions"/> if applicable.</returns>
        public static StoreRequestResult<T> Failed(T result, params Exception[] exceptions)
        {
            var item = new StoreRequestResult<T> { Result = result, Succeeded = false };
            if (exceptions != null)
            {
                item.Exceptions.AddRange(exceptions);
            }
            return item;
        }
    }
}
