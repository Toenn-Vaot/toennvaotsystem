using System.Globalization;
using System.Text;

namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="string"/>
    /// </summary>
    public static class StringExtensions
    {
        extension(string text)
        {
        /// <summary>
        /// Get the <paramref name="text"/> without any diacritics
        /// </summary>
        /// <returns>The cleaned string</returns>
        public string RemoveDiacritics()
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
        /// <param name="length">The length determined the break and start of ellipsis</param>
        /// <returns>The <paramref name="text"/> with possible ellipsis</returns>
        public string Ellipsis(int length)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= length) return text;
            return text[..length] + "...";
        }
        }
    }
}
