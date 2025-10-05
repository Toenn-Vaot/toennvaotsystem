using System.Globalization;
using ToennVaot.Components.Core.Models.Enumerations;

namespace ToennVaot.Components.Core.Extensions
{
    /// <summary>
    /// This class extends <see cref="DateTime"/>
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Get the elapsed years between current <paramref name="date"/> and <paramref name="compareDate"/>
        /// </summary>
        /// <param name="date">The current date</param>
        /// <param name="compareDate">The date to compare with</param>
        /// <returns>The elapsed years between dates</returns>
        public static int ElapsedYears(this DateTime date, DateTime compareDate)
        {
            var start = date;
            var end = compareDate;

            if(start < end)
                return compareDate.ElapsedYears(date);

            return start.Year - end.Year - 1 + (start.Month > end.Month || (start.Month == end.Month && start.Day >= end.Day) ? 1 : 0);
        }

        /// <summary>
        /// Get the elapsed months between current <paramref name="date"/> and <paramref name="compareDate"/>
        /// </summary>
        /// <param name="date">The current date</param>
        /// <param name="compareDate">The date to compare with</param>
        /// <param name="excludeYears">Exclude months from elapsed years</param>
        /// <returns>The elapsed months between dates</returns>
        public static int ElapsedMonths(this DateTime date, DateTime compareDate, bool excludeYears = false)
        {
            var start = date;
            var end = compareDate;

            if(start < end)
                return -ElapsedMonths(compareDate, date);

            return start.Month - end.Month - (start.Day < end.Day ? 1 : 0) + (end.Year - start.Year) * 12;
        }

        /// <summary>
        /// Get the elapsed months between current <paramref name="date"/> and <paramref name="compareDate"/>
        /// </summary>
        /// <param name="date">The current date</param>
        /// <param name="compareDate">The date to compare with</param>
        /// <param name="excludeYears">Exclude months from elapsed years</param>
        /// <returns>The elapsed months between dates</returns>
        public static double ElapsedDays(this DateTime date, DateTime compareDate, bool excludeYears = false)
        {
            if(!excludeYears)
                return (compareDate - date).TotalDays;
            
            var zeroTime = new DateTime(1, 1, 1);
            var span = compareDate - date;
            return (zeroTime + span).Day - 1;
        }

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
            if (date > baseComparisonDate)
                throw new ArgumentOutOfRangeException(nameof(date), "Should be less or equal from present date.");

            const byte feb28 = 59;
            // indicates whether date year has extra day compare to present date.  
            // Note, leap years have 366 days vs to 365 for regular years.  
            var extraDay = date.IsInLeapYear() && !baseComparisonDate.Value.IsInLeapYear() && date.DayOfYear > feb28
                ? 1
                : 0;

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

        #region French events

        /// <summary>
        /// Get the French event date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <param name="e">The french event to get date</param>
        /// <returns>The date</returns>
        /// <exception cref="ArgumentOutOfRangeException">Exception thrown when the <paramref name="e"/> is out of range</exception>
        public static DateTime GetFrenchEventDate(this DateTime value, FrenchEventEnum e)
        {
            var year = value.Year;
            return e switch
            {
                FrenchEventEnum.NewYearDay => new DateTime(year, 1, 1),
                FrenchEventEnum.LaborDay => new DateTime(year, 5, 1),
                FrenchEventEnum.ArmisticeDay1945 => new DateTime(year, 5, 8),
                FrenchEventEnum.July14 => new DateTime(year, 7, 14),
                _ => throw new ArgumentOutOfRangeException(nameof(e))
            };
        }

        /// <summary>
        /// Indicates whether the <paramref name="value"/> is a French event date
        /// </summary>
        /// <param name="value">This <see cref="DateTime"/> instance.</param> 
        /// <returns>The french event if found. Otherwise, null</returns>
        public static FrenchEventEnum? IsFrenchEventDate(this DateTime value)
        {
            foreach (FrenchEventEnum e in Enum.GetValues(typeof(FrenchEventEnum)))
            {
                if (value.Date == GetFrenchEventDate(value, e).Date)
                {
                    return e;
                }
            }
            return null;
        }

        #endregion

        #region Christian events

        /// <summary>
        /// Function returns the Easter date of the <paramref name="value"/>'s year
        /// </summary>
        /// <param name="value">This <see cref="DateTime"/> instance.</param> 
        /// <returns>Easter date of the <paramref name="value"/>'s year</returns>
        private static DateTime DateOfEaster(this DateTime value)
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
        /// Get the Christian event date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <param name="e">The christian event to get date</param>
        /// <returns>The date</returns>
        public static DateTime GetChristianEventDate(this DateTime value, ChristianEventEnum e)
        {
            var year = value.Year;
            switch (e)
            {
                case ChristianEventEnum.MaryMotherOfGod:
                    return new DateTime(value.Year, 1, 1);
                case ChristianEventEnum.Epiphany:
                    return new DateTime(value.Year, 1, 6);
                case ChristianEventEnum.Presentation:
                    return new DateTime(value.Year, 2, 2);
                case ChristianEventEnum.AshWednesday:
                    return DateOfEaster(value).AddDays(-46);
                case ChristianEventEnum.PalmSunday:
                    return DateOfEaster(value).AddDays(-7);
                case ChristianEventEnum.HolyThursday:
                    return DateOfEaster(value).AddDays(-3);
                case ChristianEventEnum.SaintFriday:
                    return DateOfEaster(value).AddDays(-2);
                case ChristianEventEnum.Easter:
                    return DateOfEaster(value);
                case ChristianEventEnum.EasterMonday:
                    return DateOfEaster(value).AddDays(1);
                case ChristianEventEnum.AscensionDay:
                    return DateOfEaster(value).AddDays(39);
                case ChristianEventEnum.Pentecost:
                    return DateOfEaster(value).AddDays(49);
                case ChristianEventEnum.Assumption:
                    return new DateTime(value.Year, 8, 15);
                case ChristianEventEnum.AllSaints:
                    return new DateTime(value.Year, 11, 1);
                case ChristianEventEnum.AllSouls:
                    return new DateTime(value.Year, 11, 2);
                case ChristianEventEnum.ImmaculateConception:
                    return new DateTime(value.Year, 12, 8);
                case ChristianEventEnum.ChristmasDay:
                    return new DateTime(value.Year, 12, 25);
                default:
                    throw new ArgumentOutOfRangeException(nameof(e));
            }
        }

        /// <summary>
        /// Indicates whether the <paramref name="value"/> is a Christian event date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The christian event if found. Otherwise, null</returns>
        public static ChristianEventEnum? IsChristianEventDate(this DateTime value)
        {
            foreach (ChristianEventEnum e in Enum.GetValues(typeof(ChristianEventEnum)))
            {
                if (value.Date == GetChristianEventDate(value, e).Date)
                {
                    return e;
                }
            }
            return null;
        }

        #endregion

        #region Muslim events

        private static readonly (MuslimEventEnum value, HijriMonthsEnum month, int day)[] MuslimEvents = [
            (MuslimEventEnum.NewEve, HijriMonthsEnum.Muharram, 1),
            (MuslimEventEnum.Achoura, HijriMonthsEnum.Muharram, 10),
            (MuslimEventEnum.Mawlid, HijriMonthsEnum.RabiAwwal, 12),
            (MuslimEventEnum.IsraMiRaj, HijriMonthsEnum.Rajab, 27),
            (MuslimEventEnum.MiChaaban, HijriMonthsEnum.Shaaban, 15),
            (MuslimEventEnum.RamadanStart, HijriMonthsEnum.Ramadan, 1),
            (MuslimEventEnum.LaylatAlQadr, HijriMonthsEnum.Ramadan, 27),
            (MuslimEventEnum.AidAlFitr, HijriMonthsEnum.Shawwal, 1),
            (MuslimEventEnum.ArafatDay, HijriMonthsEnum.DhuAlHijjah, 9),
            (MuslimEventEnum.AidAlAdha, HijriMonthsEnum.DhuAlHijjah, 10)
        ];

        /// <summary>
        /// Get the Muslim event date of the <paramref name="value"/>
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <param name="e">The muslim event to get date</param>
        /// <returns>The date</returns>
        public static DateTime GetMuslimEventDate(this DateTime value, MuslimEventEnum e)
        {
            var calendar = new UmAlQuraCalendar();
            var year = value.Year;

            var hijriStartYear = calendar.GetYear(new DateTime(year, 1, 1));
            var hijriEndYear = calendar.GetYear(new DateTime(year, 12, 31));

            var eventDatePart = MuslimEvents.First(x => x.value == e);
            for (var hy = hijriStartYear; hy <= hijriEndYear; hy++)
            {
                if (TryHijriToGregorian(hy, eventDatePart.month, eventDatePart.day, out var result) && result.Year == year)
                {
                    return result;
                }
            }

            return default;
        }

        /// <summary>
        /// Indicates whether the <paramref name="value"/> is a Muslim event date
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> instance</param>
        /// <returns>The muslim event if found. Otherwise, null</returns>
        public static MuslimEventEnum? IsMuslimEventDate(this DateTime value)
        {
            foreach (var e in MuslimEvents)
            {
                if (value.Date == GetMuslimEventDate(value, e.value).Date)
                {
                    return e.value;
                }
            }
            return null;
        }

        /// <summary>
        /// Convert a Hijri date to Gregorian date
        /// </summary>
        /// <param name="hijriYear">The Hijri year</param>
        /// <param name="hijriMonth">The Hijri month</param>
        /// <param name="hijriDay">The Hijri day</param>
        /// <param name="gregorianDate">The output gregorian date</param>
        /// <returns>True if succeed. Otherwise, false</returns>
        private static bool TryHijriToGregorian(int hijriYear, HijriMonthsEnum hijriMonth, int hijriDay, out DateTime gregorianDate)
        {
            try
            {
                gregorianDate = new UmAlQuraCalendar().ToDateTime(hijriYear, (int)hijriMonth, hijriDay, 0, 0, 0, 0);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                gregorianDate = default;
                return false;
            }
        }

        #endregion
    }
}
