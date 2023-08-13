namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="Enum"/>
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Get all enum values contained in bit field value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The enum values contained in the bit field value</returns>
        public static IEnumerable<Enum> GetFlags(this Enum value)
        {
            return Enum.GetValues(value.GetType()).Cast<Enum>().Where(value.HasFlag);
        }
    }
}
