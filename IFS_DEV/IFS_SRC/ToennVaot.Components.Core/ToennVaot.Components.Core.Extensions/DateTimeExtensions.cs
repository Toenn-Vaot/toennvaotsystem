namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="DateTime"/>
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Get the first day of week of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">This <see cref="DateTime"/> instance.</param>  
        /// <returns>The first day of the week of the <paramref name="value"/></returns>
        public static DateTime FirstDayOfWeek(this DateTime value)
        {
            var dtNow = new DateTime(value.Year, value.Month, value.Day);
            var n = (int)dtNow.DayOfWeek;
            n = (n + 6) % 7;

            return dtNow.AddDays(-n);
        }

        /// <summary>
        /// Get the last day of week of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">This <see cref="DateTime"/> instance.</param>  
        /// <returns>The last day of the week of the <paramref name="value"/></returns>
        public static DateTime LastDayOfWeek(this DateTime value)
        {
            var dtNow = new DateTime(value.Year, value.Month, value.Day);
            var n = (int)dtNow.DayOfWeek;
            n = (n + 6) % 7;

            return dtNow.AddDays(-n + 6);
        }
        
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

        /// <summary>
        /// Function returns the Easter date of the year
        /// </summary>
        /// <returns>Easter DateTime of the year</returns>
        public static DateTime DateOfEaster()
        {
            return DateOfEaster(DateTime.Now);
        }

        /// <summary>
        /// Function returns the Easter date of the <paramref name="value"/>'s year
        /// </summary>
        /// <param name="value">This <see cref="DateTime"/> instance.</param> 
        /// <returns>Easter date of the <paramref name="value"/>'s year</returns>
        public static DateTime DateOfEaster(this DateTime value)
        {
            var year = value.Year;

            var g = year % 19;
            var c = year / 100;
            var c4 = c / 4;
            var e = (8 * c + 13) / 25;
            var h = (19 * g + c - c4 - e + 15) % 30;
            var k = h / 28;
            var p = 29 / (h + 1);
            var q = (21 - g) / 11;
            var i = (k * p * q - 1) * k + h;
            var b = year / 4 + year;
            var j1 = b + i + 2 + c4 - c;
            var j2 = j1 % 7;
            var r = 28 + i - j2;

            return r <= 31 ? new DateTime(year, 3, r) : new DateTime(year, 4, r - 31);
        }

        /// <summary>
        /// Get the New Year date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime New_Year_Day(this DateTime value)
        {
            return new DateTime(value.Year, 1, 1);
        }

        /// <summary>
        /// Get the Work party date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Work_Party(this DateTime value)
        {
            return new DateTime(value.Year, 5, 1);
        }
        

        /// <summary>
        /// Get the World War II Armistice date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Armistice_Day_1945(this DateTime value)
        {
            return new DateTime(value.Year, 5, 8);
        }

        /// <summary>
        /// Get the National French independence date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime July_14(this DateTime value)
        {
            return new DateTime(value.Year, 7, 14);
        }
        
        /// <summary>
        /// Get the Assumption date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Assumption(this DateTime value)
        {
            return new DateTime(value.Year, 8, 15);
        }
        
        /// <summary>
        /// Get the Saints date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Saints_Day(this DateTime value)
        {
            return new DateTime(value.Year, 11, 1);
        }

        /// <summary>
        /// Get the Christmas date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Christmas_Day(this DateTime value)
        {
            return new DateTime(value.Year, 12, 25);
        }

        /// <summary>
        /// Get the Saint Friday date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Saint_Friday(this DateTime value)
        {
            return DateOfEaster(value).AddDays(-2);
        }
        
        /// <summary>
        /// Get the Easter Monday date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Easter_Monday(this DateTime value)
        {
            return DateOfEaster(value).AddDays(1);
        }

        /// <summary>
        /// Get the Ascension date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Ascension_Day(this DateTime value)
        {
            return DateOfEaster(value).AddDays(39);
        }

        /// <summary>
        /// Get the Pentecost date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The date</returns>
        public static DateTime Pentecost(this DateTime value)
        {
            return DateOfEaster(value).AddDays(50);
        }

        /// <summary>
        /// Indicates if the <paramref name="value"/> is New Year date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsNew_Year_Day(this DateTime value)
        {
            return value.CompareTo(value.New_Year_Day()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is Work Party date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsWork_Party(this DateTime value)
        {
            return value.CompareTo(value.Work_Party()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is World War II Armistice date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsArmistice_Day_1945(this DateTime value)
        {
            return value.CompareTo(value.Armistice_Day_1945()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is National French independence date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsJuly_14(this DateTime value)
        {
            return value.CompareTo(value.July_14()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is Assumption date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsAssumption(this DateTime value)
        {
            return value.CompareTo(value.Assumption()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is Saints date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsSaints_Day(this DateTime value)
        {
            return value.CompareTo(value.Saints_Day()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is Chrsitmas date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsChristmas_Day(this DateTime value)
        {
            return value.CompareTo(value.Christmas_Day()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is Saint Friday date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsSaint_Friday(this DateTime value)
        {
            return value.CompareTo(value.Saint_Friday()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is Easter Monday date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsEaster_Monday(this DateTime value)
        {
            return value.CompareTo(value.Easter_Monday()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is Ascension date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsAscension_Day(this DateTime value)
        {
            return value.CompareTo(value.Ascension_Day()) == 0;
        }
        
        /// <summary>
        /// Indicates if the <paramref name="value"/> is Pentecost date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>True. Otherwise, false</returns>
        public static bool IsPentecost(this DateTime value)
        {
            return value.CompareTo(value.Pentecost()) == 0;
        }
    }
}
