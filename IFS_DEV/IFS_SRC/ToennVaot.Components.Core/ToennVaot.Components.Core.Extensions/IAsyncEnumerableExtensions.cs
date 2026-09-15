namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="IAsyncEnumerable{T}"/>
    /// </summary>
    public static class IAsyncEnumerableExtensions
    {
        extension<T>(IAsyncEnumerable<T> source)
        {
        /// <summary>
        /// Get the list of T objects
        /// </summary>
        /// <returns>The list of T objects</returns>
        public Task<List<T>> ToListAsync()
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return ExecuteAsync();

            async Task<List<T>> ExecuteAsync()
            {
                var list = new List<T>();

                await foreach (var element in source)
                {
                    list.Add(element);
                }

                return list;
            }
        }
        }
    }
}
