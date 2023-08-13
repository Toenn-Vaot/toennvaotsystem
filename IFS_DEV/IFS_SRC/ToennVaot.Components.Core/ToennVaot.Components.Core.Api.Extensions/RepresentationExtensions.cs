using ToennVaot.Components.Core.Api.Models.Hal;

namespace ToennVaot.Components.Core.Api.Extensions
{
    /// <summary>
    /// This class extends <see cref="Representation"/>
    /// </summary>
    public static class RepresentationExtensions
    {
        /// <summary>
        /// Add the relation link "self"
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public static void AddSelfRelation(this Representation item, string url, HttpMethod method)
        {
            item.AddSelfRelation(new Link { Href = url, Method = method });
        }
        
        /// <summary>
        /// Add the relation link "self"
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="link">The link</param>
        public static void AddSelfRelation(this Representation item, Link link)
        {
            item.AddRelation("self", link);
        }

        /// <summary>
        /// Add the relation link "search"
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public static void AddSearchRelation(this Representation item, string url, HttpMethod method)
        {
            item.AddSearchRelation(new Link { Href = url, Method = method });
        }
        
        /// <summary>
        /// Add the relation link "search"
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="link">The link</param>
        public static void AddSearchRelation(this Representation item, Link link)
        {
            item.AddRelation("search", link);
        }

        /// <summary>
        /// Add the relation link "first" in pagination context
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public static void AddFirstRelation(this Representation item, string url, HttpMethod method)
        {
            item.AddFirstRelation(new Link { Href = url, Method = method });
        }
        
        /// <summary>
        /// Add the relation link "first" in pagination context
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="link">The link</param>
        public static void AddFirstRelation(this Representation item, Link link)
        {
            item.AddRelation("first", link);
        }

        /// <summary>
        /// Add the relation link "previous" in pagination context
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public static void AddPreviousRelation(this Representation item, string url, HttpMethod method)
        {
            item.AddPreviousRelation(new Link { Href = url, Method = method });
        }
        
        /// <summary>
        /// Add the relation link "previous" in pagination context
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="link">The link</param>
        public static void AddPreviousRelation(this Representation item, Link link)
        {
            item.AddRelation("previous", link);
        }

        /// <summary>
        /// Add the relation link "next" in pagination context
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public static void AddNextRelation(this Representation item, string url, HttpMethod method)
        {
            item.AddNextRelation(new Link { Href = url, Method = method });
        }
        
        /// <summary>
        /// Add the relation link "next" in pagination context
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="link">The link</param>
        public static void AddNextRelation(this Representation item, Link link)
        {
            item.AddRelation("next", link);
        }

        /// <summary>
        /// Add the relation link described by <paramref name="rel"/>
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="rel">The relation type</param>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public static void AddRelation(this Representation item, string rel, string url, HttpMethod method)
        {
            item.AddRelation(rel, new Link { Rel = rel, Href = url, Method = method });
        }

        /// <summary>
        /// Add the relation described by <paramref name="rel"/> with <paramref name="link"/> value
        /// </summary>
        /// <param name="item">The extend object</param>
        /// <param name="rel">The relation type</param>
        /// <param name="link">The link</param>
        public static void AddRelation(this Representation item, string rel, Link link)
        {
            if(string.IsNullOrWhiteSpace(rel))
                throw new ArgumentNullException(nameof(rel));

            if (string.IsNullOrWhiteSpace(link.Rel))
                link.Rel = rel;

            if (item.Links.ContainsKey(rel))
                item.Links.Remove(rel);
            item.Links.Add(rel, link);
        }
    }
}
