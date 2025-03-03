using NUnit.Framework;
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
        /// Test <see cref="DateTimeExtensions.IsInLeapYear"/>
        /// </summary>
        /// <param name="date"></param>
        [TestCase("2025-01-01")]
        [TestCase("2024-01-01")]
        [TestCase("2023-01-01")]
        [TestCase("2022-01-01")]
        [TestCase("2021-01-01")]
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
        public void CalculateAgeInYearsWithBirthdayNotPassedTest(DateTime date)
        {
            var result = date.AddDays(2).CalculateAgeInYears();
            Assert.That(DateTime.Now.Year - date.Year - 1 == result);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.CalculateAgeInYears"/>
        /// </summary>
        [Test]
        public void CalculateAgeInYearsWithBirthdayPassedTest()
        {
            var date = DateTime.Now.AddYears(-18).AddDays(-2);
            var result = DateTime.Now.AddDays(-2).CalculateAgeInYears();
            Assert.That(DateTime.Now.Year - date.Year == 18);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.CalculateAgeInYears"/>
        /// </summary>
        [Test]
        public void CalculateAgeInYearsWithBirthdayPassedForSomeoneBirth29FebruaryTest()
        {
            var date = new DateTime(2024,2, 29);
            var result = date.CalculateAgeInYears();
            Assert.That(DateTime.Now.Year - date.Year - (DateTime.Now.Month > 2 ? 0 : 1) == result);
        }

        /// <summary>
        /// Test <see cref="DateTimeExtensions.CalculateAgeInYears"/>
        /// </summary>
        [Test]
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
        [TestCase("2024-01-01 14:02:33")]
        [TestCase("2023-01-01 21:40:54")]
        [TestCase("2022-01-01 23:02:33")]
        [TestCase("2021-01-01 01:11:44")]
        [TestCase(null)]
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
    }
}
