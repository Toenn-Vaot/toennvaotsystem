using ToennVaot.Components.Core.Models.Enumerations;

namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="GenderEnum"/>
    /// </summary>
    public static class GenderEnumExtensions
    {
        extension(GenderEnum value)
        {
        /// <summary>
        /// Get the equivalent pronoun of the gender enumeration value
        /// </summary>
        /// <returns>The pronoun</returns>
        public string ToPronoun()
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
}