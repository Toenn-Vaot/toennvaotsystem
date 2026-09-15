namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="Enum"/>
    /// </summary>
    public static class EnumExtensions
    {
        extension(Enum value)
        {
        /// <summary>
        /// Get all enum values contained in bit field value
        /// </summary>
        /// <returns>The enum values contained in the bit field value</returns>
        public IEnumerable<Enum> GetFlags()
        {
            return Enum.GetValues(value.GetType()).Cast<Enum>().Where(value.HasFlag);
        }
        }
    }
}
