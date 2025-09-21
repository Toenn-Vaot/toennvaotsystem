using NUnit.Framework;
using ToennVaot.Components.Core.Models.Enumerations;
using Assert = NUnit.Framework.Assert;

namespace ToennVaot.Components.Core.Extensions.Tests
{
    /// <summary>
    /// The unit test class for <see cref="DateTimeExtensions"/>
    /// </summary>
    public class DateTimeExtensionsTests
    {
        /// <summary>
        /// Set up the unit test class
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.FirstDayOfWeek"/>
        /// </summary>
        /// <param name="date"></param>
        /// <param name="assertDate"></param>
        [TestCase("2025-09-20", "2025-09-15")]
        [Category("DateTime_Basics")]
        public void FirstDayOfWeekTest(DateTime date, DateTime assertDate)
        {
            var result = date.FirstDayOfWeek();
            Assert.That(result.Date == assertDate.Date);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.LastDayOfWeek"/>
        /// </summary>
        /// <param name="date"></param>
        /// <param name="assertDate"></param>
        [TestCase("2025-09-20", "2025-09-21")]
        [Category("DateTime_Basics")]
        public void LastDayOfWeekTest(DateTime date, DateTime assertDate)
        {
            var result = date.LastDayOfWeek();
            Assert.That(result.Date == assertDate.Date);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.IsInLeapYear"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2025-01-01")]
        [TestCase("2024-01-01")]
        [TestCase("2023-01-01")]
        [TestCase("2022-01-01")]
        [TestCase("2021-01-01")]
        [Category("DateTime_Basics")]
        public void IsInLeapYearTest(DateTime date)
        {
            var result = date.IsInLeapYear();
            Assert.That(result == DateTime.IsLeapYear(date.Year));
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.CalculateAgeInYears"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("1987-08-29")]
        [TestCase("1987-07-05")]
        [TestCase("1985-06-24")]
        [Category("DateTime_Basics")]
        public void CalculateAgeInYearsWithBirthdayNotPassedTest(DateTime date)
        {
            var result = date.AddDays(2).CalculateAgeInYears();
            Assert.That(DateTime.Now.Year - date.Year - ((DateTime.Now.Month < date.Month || DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day) ? 1 : 0) == result);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.CalculateAgeInYears"/>
        /// </summary>
        [Test]
        [Category("DateTime_Basics")]
        public void CalculateAgeInYearsWithBirthdayPassedTest()
        {
            var date = DateTime.Now.AddYears(-18).AddDays(-2);
            var result = DateTime.Now.AddDays(-2).CalculateAgeInYears();
            Assert.That(DateTime.Now.Year - date.Year == 18);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.CalculateAgeInYears"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2024-02-29")]
        [TestCase("2025-03-01")]
        [Category("DateTime_Basics")]
        public void CalculateAgeInYearsWithBirthdayPassedForSomeoneBirth29FebruaryTest(DateTime date)
        {
            var result = date.CalculateAgeInYears();
            Assert.That(DateTime.Now.Year - date.Year - (DateTime.Now.Month > 2 ? 0 : 1) == result);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.CalculateAgeInYears"/>
        /// </summary>
        [Test]
        [Category("DateTime_Basics")]
        public void CalculateAgeInYearsThrowsArgumentOutOfRangeExceptionTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => DateTime.Now.AddDays(1).CalculateAgeInYears());
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.SpecifyKindAsLocal(System.DateTime)"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2025-01-01 01:02:33")]
        [TestCase("2024-01-01 14:02:33")]
        [TestCase("2023-01-01 21:40:54")]
        [TestCase("2022-01-01 23:02:33")]
        [TestCase("2021-01-01 01:11:44")]
        [Category("DateTime_Basics")]
        public void SpecifyKindAsLocalTest(DateTime date)
        {
            var result = date.SpecifyKindAsLocal();
            Assert.That(result.Kind == DateTimeKind.Local);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.SpecifyKindAsLocal(System.DateTime?)"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2025-01-01 01:02:33")]
        [TestCase("2024-01-01 14:02:33")]
        [TestCase("2023-01-01 21:40:54")]
        [TestCase("2022-01-01 23:02:33")]
        [TestCase("2021-01-01 01:11:44")]
        [TestCase(null)]
        [Category("DateTime_Basics")]
        public void SpecifyKindAsLocalTest(DateTime? date)
        {
            var result = date.SpecifyKindAsLocal();
            if(date != null)
                Assert.That(result?.Kind == DateTimeKind.Local);
            else
                Assert.That(result == null);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.SpecifyKindAsUtc(System.DateTime)"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2025-01-01 01:02:33")]
        [TestCase("2024-01-01 14:02:33")]
        [TestCase("2023-01-01 21:40:54")]
        [TestCase("2022-01-01 23:02:33")]
        [TestCase("2021-01-01 01:11:44")]
        [Category("DateTime_Basics")]
        public void SpecifyKindAsUtcTest(DateTime date)
        {
            var result = date.SpecifyKindAsUtc();
            Assert.That(result.Kind == DateTimeKind.Utc);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.SpecifyKindAsUtc(System.DateTime?)"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2025-01-01 01:02:33")]
        [TestCase("2024-01-01 14:02:33")]
        [TestCase("2023-01-01 21:40:54")]
        [TestCase("2022-01-01 23:02:33")]
        [TestCase("2021-01-01 01:11:44")]
        [TestCase(null)]
        [Category("DateTime_Basics")]
        public void SpecifyKindAsUtcTest(DateTime? date)
        {
            var result = date.SpecifyKindAsUtc();
            if (date != null)
                Assert.That(result?.Kind == DateTimeKind.Utc);
            else
                Assert.That(result == null);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.ResetTimePart(System.DateTime)"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2025-01-01 01:02:33")]
        [TestCase("2024-01-01 14:02:33")]
        [TestCase("2023-01-01 21:40:54")]
        [TestCase("2022-01-01 23:02:33")]
        [TestCase("2021-01-01 01:11:44")]
        [Category("DateTime_Basics")]
        public void ResetTimePartTest(DateTime date)
        {
            var result = date.ResetTimePart();
            Assert.That(result.Hour == 0);
            Assert.That(result.Minute == 0);
            Assert.That(result.Second == 0);
            Assert.That(result.Millisecond == 0);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.ResetTimePart(System.DateTime)"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2025-01-01 01:02:33")]
        [TestCase("2025-01-01 00:00:00")]
        [TestCase("2024-01-01 14:02:33")]
        [TestCase("2023-01-01 21:40:54")]
        [TestCase("2022-01-01 23:02:33")]
        [TestCase("2021-01-01 01:11:44")]
        [TestCase(null)]
        [Category("DateTime_Basics")]
        public void ResetTimePartTest(DateTime? date)
        {
            var result = date.ResetTimePart();

            if (date != null)
            {
                Assert.That(result?.Hour == 0);
                Assert.That(result?.Minute == 0);
                Assert.That(result?.Second == 0);
                Assert.That(result?.Millisecond == 0);
            }
            else
            {
                Assert.That(result == null);
            }
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.GetFrenchEventDate(DateTime, FrenchEventEnum)"/>
        /// </summary>
        /// <param name="ev"></param>
        /// <param name="year"></param>
        /// <param name="assertMonth"></param>
        /// <param name="assertDay"></param>
        [TestCase(FrenchEventEnum.NewYearDay, 2025, 1, 1)]
        [TestCase(FrenchEventEnum.LaborDay, 2025, 5, 1)]
        [TestCase(FrenchEventEnum.ArmisticeDay1945, 2025, 5, 8)]
        [TestCase(FrenchEventEnum.July14, 2025, 7, 14)]
        [Category("DateTime_French")]
        public void GetFrenchEventDateTest(FrenchEventEnum ev, int year, int assertMonth, int assertDay)
        {
            var date = new DateTime(year, 1, 1).GetFrenchEventDate(ev);

            Assert.That(date.Year == year);
            Assert.That(date.Month == assertMonth);
            Assert.That(date.Day == assertDay);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.IsFrenchEventDate(DateTime)"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="assertEvent"></param>
        [TestCase("2025-01-01", FrenchEventEnum.NewYearDay)]
        [TestCase("2025-05-01", FrenchEventEnum.LaborDay)]
        [TestCase("2025-05-08", FrenchEventEnum.ArmisticeDay1945)]
        [TestCase("2025-07-14", FrenchEventEnum.July14)]
        [TestCase("2025-12-26", null)]
        [Category("DateTime_French")]
        public void IsFrenchEventDateTest(DateTime value, FrenchEventEnum? assertEvent)
        {
            var ev = value.IsFrenchEventDate();

            Assert.That(ev == assertEvent);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.GetChristianEventDate(DateTime, ChristianEventEnum)"/>
        /// </summary>
        /// <param name="ev"></param>
        /// <param name="year"></param>
        /// <param name="assertMonth"></param>
        /// <param name="assertDay"></param>
        [TestCase(ChristianEventEnum.MaryMotherOfGod, 2025, 1, 1)]
        [TestCase(ChristianEventEnum.Epiphany, 2025, 1, 6)]
        [TestCase(ChristianEventEnum.Presentation, 2025, 2, 2)]
        [TestCase(ChristianEventEnum.AshWednesday, 2025, 3, 5)]
        [TestCase(ChristianEventEnum.PalmSunday, 2025, 4, 13)]
        [TestCase(ChristianEventEnum.HolyThursday, 2025, 4, 17)]
        [TestCase(ChristianEventEnum.SaintFriday, 2025, 4, 18)]
        [TestCase(ChristianEventEnum.Easter, 2025, 4, 20)]
        [TestCase(ChristianEventEnum.EasterMonday, 2025, 4, 21)]
        [TestCase(ChristianEventEnum.AscensionDay, 2025, 5, 29)]
        [TestCase(ChristianEventEnum.Pentecost, 2025, 6, 8)]
        [TestCase(ChristianEventEnum.Assumption, 2025, 8, 15)]
        [TestCase(ChristianEventEnum.AllSaints, 2025, 11, 1)]
        [TestCase(ChristianEventEnum.AllSouls, 2025, 11, 2)]
        [TestCase(ChristianEventEnum.ImmaculateConception, 2025, 12, 8)]
        [TestCase(ChristianEventEnum.ChristmasDay, 2025, 12, 25)]
        [Category("DateTime_Christian")]
        public void GetChristianEventDateTest(ChristianEventEnum ev, int year, int assertMonth, int assertDay)
        {
            var date = new DateTime(year, 1, 1).GetChristianEventDate(ev);

            Assert.That(date.Year == year);
            Assert.That(date.Month == assertMonth);
            Assert.That(date.Day == assertDay);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.GetChristianEventDate(DateTime, ChristianEventEnum)"/>
        /// </summary>
        /// <param name="ev"></param>
        /// <param name="year"></param>
        /// <param name="assertMonth"></param>
        /// <param name="assertDay"></param>
        [TestCase(ChristianEventEnum.MaryMotherOfGod, 2024, 1, 1)]
        [TestCase(ChristianEventEnum.Epiphany, 2024, 1, 6)]
        [TestCase(ChristianEventEnum.Presentation, 2024, 2, 2)]
        [TestCase(ChristianEventEnum.AshWednesday, 2024, 2, 14)]
        [TestCase(ChristianEventEnum.PalmSunday, 2024, 3, 24)]
        [TestCase(ChristianEventEnum.HolyThursday, 2024, 3, 28)]
        [TestCase(ChristianEventEnum.SaintFriday, 2024, 3, 29)]
        [TestCase(ChristianEventEnum.Easter, 2024, 3, 31)]
        [TestCase(ChristianEventEnum.EasterMonday, 2024, 4, 1)]
        [TestCase(ChristianEventEnum.AscensionDay, 2024, 5, 9)]
        [TestCase(ChristianEventEnum.Pentecost, 2024, 5, 19)]
        [TestCase(ChristianEventEnum.Assumption, 2024, 8, 15)]
        [TestCase(ChristianEventEnum.AllSaints, 2024, 11, 1)]
        [TestCase(ChristianEventEnum.AllSouls, 2024, 11, 2)]
        [TestCase(ChristianEventEnum.ImmaculateConception, 2024, 12, 8)]
        [TestCase(ChristianEventEnum.ChristmasDay, 2024, 12, 25)]
        [Category("DateTime_Christian")]
        public void GetChristianEventDateOnLeapYearTest(ChristianEventEnum ev, int year, int assertMonth, int assertDay)
        {
            var date = new DateTime(year, 1, 1).GetChristianEventDate(ev);

            Assert.That(date.Year == year);
            Assert.That(date.Month == assertMonth);
            Assert.That(date.Day == assertDay);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.IsChristianEventDate(DateTime)"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="assertEvent"></param>
        [TestCase("2025-01-01", ChristianEventEnum.MaryMotherOfGod)]
        [TestCase("2025-01-06", ChristianEventEnum.Epiphany)]
        [TestCase("2025-02-02", ChristianEventEnum.Presentation)]
        [TestCase("2025-03-05", ChristianEventEnum.AshWednesday)]
        [TestCase("2025-04-13", ChristianEventEnum.PalmSunday)]
        [TestCase("2025-04-17", ChristianEventEnum.HolyThursday)]
        [TestCase("2025-04-18", ChristianEventEnum.SaintFriday)]
        [TestCase("2025-04-20", ChristianEventEnum.Easter)]
        [TestCase("2025-04-21", ChristianEventEnum.EasterMonday)]
        [TestCase("2025-05-29", ChristianEventEnum.AscensionDay)]
        [TestCase("2025-06-08", ChristianEventEnum.Pentecost)]
        [TestCase("2025-08-15", ChristianEventEnum.Assumption)]
        [TestCase("2025-11-01", ChristianEventEnum.AllSaints)]
        [TestCase("2025-11-02", ChristianEventEnum.AllSouls)]
        [TestCase("2025-12-08", ChristianEventEnum.ImmaculateConception)]
        [TestCase("2025-12-25", ChristianEventEnum.ChristmasDay)]
        [TestCase("2025-12-26", null)]
        [Category("DateTime_Christian")]
        public void IsChristianEventDateTest(DateTime value, ChristianEventEnum? assertEvent)
        {
            var ev = value.IsChristianEventDate();

            Assert.That(ev == assertEvent);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.GetMuslimEventDate(DateTime, MuslimEventEnum)"/>
        /// </summary>
        /// <param name="ev"></param>
        /// <param name="year"></param>
        /// <param name="assertMonth"></param>
        /// <param name="assertDay"></param>
        [TestCase(MuslimEventEnum.NewEve, 2025, 6, 26)]
        [TestCase(MuslimEventEnum.Achoura, 2025, 7, 5)]
        [TestCase(MuslimEventEnum.IsraMiRaj, 2025, 1, 27)]
        [TestCase(MuslimEventEnum.MiChaaban, 2025, 2, 14)]
        [TestCase(MuslimEventEnum.RamadanStart, 2025, 3, 1)]
        [TestCase(MuslimEventEnum.LaylatAlQadr, 2025, 3, 27)]
        [TestCase(MuslimEventEnum.AidAlFitr, 2025, 3, 30)]
        [TestCase(MuslimEventEnum.ArafatDay, 2025, 6, 5)]
        [TestCase(MuslimEventEnum.AidAlAdha, 2025, 6, 6)]
        [Category("DateTime_Muslim")]
        public void MuslimEventsTest(MuslimEventEnum ev, int year, int assertMonth, int assertDay)
        {
            var date = new DateTime(year, 1, 1).GetMuslimEventDate(ev);

            Assert.That(date.Year == year);
            Assert.That(date.Month == assertMonth);
            Assert.That(date.Day == assertDay);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.IsChristianEventDate(DateTime)"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="assertEvent"></param>
        [TestCase("2025-06-26", MuslimEventEnum.NewEve)]
        [TestCase("2025-07-05", MuslimEventEnum.Achoura)]
        [TestCase("2025-01-27", MuslimEventEnum.IsraMiRaj)]
        [TestCase("2025-02-14", MuslimEventEnum.MiChaaban)]
        [TestCase("2025-03-01", MuslimEventEnum.RamadanStart)]
        [TestCase("2025-03-27", MuslimEventEnum.LaylatAlQadr)]
        [TestCase("2025-03-30", MuslimEventEnum.AidAlFitr)]
        [TestCase("2025-06-05", MuslimEventEnum.ArafatDay)]
        [TestCase("2025-06-06", MuslimEventEnum.AidAlAdha)]
        [TestCase("2025-12-26", null)]
        [Category("DateTime_Christian")]
        public void IsMuslimEventDateTest(DateTime value, MuslimEventEnum? assertEvent)
        {
            var ev = value.IsMuslimEventDate();

            Assert.That(ev == assertEvent);
        }
    }
}
