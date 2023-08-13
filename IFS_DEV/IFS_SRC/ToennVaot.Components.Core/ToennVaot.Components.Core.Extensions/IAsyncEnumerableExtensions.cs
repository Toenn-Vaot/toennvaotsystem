namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="IAsyncEnumerable{T}"/>
    /// </summary>
    public static class IAsyncEnumerableExtensions
    {
        /// <summary>
        /// Get the list of <typeparamref name="T"/> objects
        /// </summary>
        /// <typeparam name="T">The type of object</typeparam>
        /// <param name="source">The async enumerable collection</param>
        /// <returns>The list of <typeparamref name="T"/> objects</returns>
        public static Task<List<T>> ToListAsync<T>(this IAsyncEnumerable<T> source)
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
