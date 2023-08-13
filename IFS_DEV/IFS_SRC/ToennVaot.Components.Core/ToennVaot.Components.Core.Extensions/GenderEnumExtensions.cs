using ToennVaot.Components.Core.Models;

namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="GenderEnum"/>
    /// </summary>
    public static class GenderEnumExtensions
    {
        /// <summary>
        /// Get the equivalent pronoun of the gender enumeration value
        /// </summary>
        /// <param name="value">The enumeration value</param>
        /// <returns>The pronoun</returns>
        public static string ToPronoun(this GenderEnum value)
        {
            return value switch
            {
                GenderEnum.KeepQuiet => string.Empty,
                GenderEnum.Male => "He",
                GenderEnum.Female => "She",
                GenderEnum.Other => "They",
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }
    }
}