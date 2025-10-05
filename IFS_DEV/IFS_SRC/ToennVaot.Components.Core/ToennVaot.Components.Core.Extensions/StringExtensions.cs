using System.Globalization;
using System.Text;

namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="string"/>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Get the <paramref name="text"/> without any diacritics
        /// </summary>
        /// <param name="text">The string with diacritics to remove</param>
        /// <returns>The cleaned string</returns>
        public static string RemoveDiacritics(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;
            text = text.Normalize(NormalizationForm.FormD);
            var chars =
                text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
            return new string(chars).Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Ellipse the <paramref name="text"/> with specified <paramref name="length"/>
        /// </summary>
        /// <param name="text">The text to ellipse</param>
        /// <param name="length">The length determined the break and start of ellipsis</param>
        /// <returns>The <paramref name="text"/> with possible ellipsis</returns>
        public static string Ellipsis(this string text, int length)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= length) return text;
            return text[..length] + "...";
        }
    }
}
