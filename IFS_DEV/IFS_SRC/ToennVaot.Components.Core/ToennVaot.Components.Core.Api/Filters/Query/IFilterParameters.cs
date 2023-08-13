using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using ToennVaot.Components.Core.Models;

namespace ToennVaot.Components.Core.Api.Filters.Query
{
    /// <summary>
    /// The interface defines the base of filter parameter collection which can be used in request
    /// </summary>
    /// <typeparam name="T">The input object type to apply filter</typeparam>
    public interface IFilterParameters<T>
    {
        /// <summary>
        /// Construct the filter expression
        /// </summary>
        /// <returns>The filter expression</returns>
        Expression<Func<T, bool>> Construct();
    }

    /// <summary>
    /// The interface defines the base of filter parameter collection which can be used in request with pagination of results
    /// </summary>
    public interface IFilterPagingParameters
    {
        /// <summary>
        /// The page number
        /// </summary>
        [FromQuery(Name = "page")]
        int Page { get; set; }

        /// <summary>
        /// The page size
        /// </summary>
        [FromQuery(Name = "size")]
        int PageSize { get; set; }
    }

    /// <summary>
    /// The interface defines the base of filter parameter collection which can be used in request with ordering of results
    /// </summary>
    public interface IFilterSortingParameters
    {
        /// <summary>
        /// The sort direction
        /// </summary>
        [FromQuery(Name = "sort")]
        SortDirectionEnum SortDirection { get; set; }
    }
}
