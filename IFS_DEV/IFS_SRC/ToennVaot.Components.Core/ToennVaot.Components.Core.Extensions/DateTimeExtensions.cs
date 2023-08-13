namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="DateTime"/>
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>  
        /// Indicates whether this date is in leap year.  
        /// </summary>  
        /// <param name="value">This <see cref="DateTime"/> instance.</param>  
        /// <returns>A boolean value indicating whether this date instance is in leap your.</returns>  
        public static bool IsInLeapYear(this DateTime value)
        {
            return DateTime.IsLeapYear(value.Year);
        }

        /// <summary>  
        /// Calculate the age of a person based on the date of birth.  
        /// </summary>  
        /// <param name="date">The date of birth of the person.</param>  
        /// <param name="baseComparisonDate">The present date. Defaults to <see cref="DateTime.Now"/>, if not specified.</param>  
        /// <remarks>This function supports leaper Birthdate (Feb 29).</remarks>  
        /// <returns>Age in years</returns>  
        public static int CalculateAgeInYears(this DateTime date, DateTime? baseComparisonDate = null)
        {
            baseComparisonDate ??= DateTime.Now.Date;
            if (date > baseComparisonDate) throw new ArgumentOutOfRangeException(nameof(date), "Should be less or equal from present date.");

            const byte feb28 = 59;
            // indicates whether date year has extra day compare to present date.  
            // Note, leap years have 366 days vs to 365 for regular years.  
            var extraDay = date.IsInLeapYear() && !baseComparisonDate.Value.IsInLeapYear() && date.DayOfYear > feb28 ? 1 : 0;

            // indicates whether date has been celebrated in the present year.  
            var hasDobOccur = baseComparisonDate.Value.DayOfYear >= date.DayOfYear - extraDay;

            // calculate the years of age  
            return baseComparisonDate.Value.Year - date.Year - (hasDobOccur ? 0 : 1);
        }
        
        /// <summary>
        /// Force the Date kind as Local
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime SpecifyKindAsLocal(this DateTime date)
        {
            return DateTime.SpecifyKind(date, DateTimeKind.Local);
        }

        /// <summary>
        /// Force the Date kind as Local
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime? SpecifyKindAsLocal(this DateTime? date)
        {
            return date.HasValue ? SpecifyKindAsLocal(date.Value) : null;
        }

        /// <summary>
        /// Force the Date kind as UTC
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime SpecifyKindAsUtc(this DateTime date)
        {
            return DateTime.SpecifyKind(date, DateTimeKind.Utc);
        }

        /// <summary>
        /// Force the Date kind as UTC
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime? SpecifyKindAsUtc(this DateTime? date)
        {
            return date.HasValue ? SpecifyKindAsUtc(date.Value) : null;
        }

        /// <summary>
        /// Reset the Time part to 00:00:00
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime ResetTimePart(this DateTime date)
        {
            return date.Date;
        }

        /// <summary>
        /// Reset the Time part to 00:00:00
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime? ResetTimePart(this DateTime? date)
        {
            return date.HasValue ? ResetTimePart(date.Value) : null;
        }
    }
}
