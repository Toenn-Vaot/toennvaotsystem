using ToennVaot.Components.Core.Api.Models.Hal;

namespace ToennVaot.Components.Core.Api.Extensions
{
    /// <summary>
    /// This class extends <see cref="Representation"/>
    /// </summary>
    public static class RepresentationExtensions
    {
        extension(Representation item)
        {
        /// <summary>
        /// Add the relation link "self"
        /// </summary>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public void AddSelfRelation(string url, HttpMethod method)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            item.AddSelfRelation(new Link { Href = url, Method = method });
        }
        
        /// <summary>
        /// Add the relation link "self"
        /// </summary>
        /// <param name="link">The link</param>
        public void AddSelfRelation(Link link)
        {
            item.AddRelation(link, "self");
        }

        /// <summary>
        /// Add the relation link "search"
        /// </summary>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public void AddSearchRelation(string url, HttpMethod method)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            item.AddSearchRelation(new Link { Href = url, Method = method });
        }

        /// <summary>
        /// Add the relation link "search"
        /// </summary>
        /// <param name="link">The link</param>
        public void AddSearchRelation(Link link)
        {
            item.AddRelation(link, "search");
        }

        /// <summary>
        /// Add the relation link "first" in pagination context
        /// </summary>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public void AddFirstRelation(string url, HttpMethod method)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            item.AddFirstRelation(new Link { Href = url, Method = method });
        }

        /// <summary>
        /// Add the relation link "first" in pagination context
        /// </summary>
        /// <param name="link">The link</param>
        public void AddFirstRelation(Link link)
        {
            item.AddRelation(link, "first");
        }

        /// <summary>
        /// Add the relation link "previous" in pagination context
        /// </summary>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public void AddPreviousRelation(string url, HttpMethod method)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            item.AddPreviousRelation(new Link { Href = url, Method = method });
        }
        
        /// <summary>
        /// Add the relation link "previous" in pagination context
        /// </summary>
        /// <param name="link">The link</param>
        public void AddPreviousRelation(Link link)
        {
            item.AddRelation(link, "previous");
        }

        /// <summary>
        /// Add the relation link "next" in pagination context
        /// </summary>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public void AddNextRelation(string url, HttpMethod method)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            item.AddNextRelation(new Link { Href = url, Method = method });
        }
        
        /// <summary>
        /// Add the relation link "next" in pagination context
        /// </summary>
        /// <param name="link">The link</param>
        public void AddNextRelation(Link link)
        {
            item.AddRelation(link, "next");
        }

        /// <summary>
        /// Add the relation link described by <paramref name="rel"/>
        /// </summary>
        /// <param name="rel">The relation type</param>
        /// <param name="url">The url of link</param>
        /// <param name="method">The HTTP method</param>
        public void AddRelation(string rel, string url, HttpMethod method)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            item.AddRelation(new Link { Rel = rel, Href = url, Method = method }, rel);
        }

        /// <summary>
        /// Add the relation described by <paramref name="rel"/> with <paramref name="link"/> value
        /// </summary>
        /// <param name="link">The link</param>
        /// <param name="rel">The relation type</param>
        public void AddRelation(Link link, string rel)
        {
            if(string.IsNullOrWhiteSpace(rel))
                throw new ArgumentNullException(nameof(rel));

            if (!string.IsNullOrWhiteSpace(rel))
                link.Rel = rel;

            if (item.Links.ContainsKey(rel))
                item.Links.Remove(rel);
            item.Links.Add(rel, link);
        }
        }
    }
}
