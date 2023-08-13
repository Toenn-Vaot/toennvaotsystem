namespace ToennVaot.Components.Core.Api.Results.Interfaces
{
    /// <summary>
    /// The interface defines the base of filter results which can be used in request response
    /// </summary>
    /// <typeparam name="T">The object type of the result items</typeparam>
    public interface IFilterResults<T>
    {
        /// <summary>
        /// The result items collection
        /// </summary>
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        /// Indicates there are more items
        /// </summary>
        public bool HasMoreItems { get; set; }
    }
}
