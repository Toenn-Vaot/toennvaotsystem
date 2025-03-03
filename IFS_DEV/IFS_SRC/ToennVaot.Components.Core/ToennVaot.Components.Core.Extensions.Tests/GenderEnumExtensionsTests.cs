using NUnit.Framework;
using ToennVaot.Components.Core.Models;
using Assert = NUnit.Framework.Assert;

namespace ToennVaot.Components.Core.Extensions.Tests;

/// <summary>
/// The unit test class for <see cref="GenderEnumExtensions"/>
/// </summary>
public class GenderEnumExtensionsTests
{
    /// <summary>
    /// Set up the unit test class
    /// </summary>
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Test <see cref="GenderEnumExtensions.ToPronoun"/>
    /// </summary>
    [TestCase(GenderEnum.Male, "He")]
    [TestCase(GenderEnum.Female, "She")]
    [TestCase(GenderEnum.KeepQuiet, "")]
    [TestCase(GenderEnum.Other, "They")]
    public void ToPronounTest(GenderEnum gender, string expected)
    {
        var result = gender.ToPronoun();
        Assert.That(result == expected);
    }

    /// <summary>
    /// Test <see cref="GenderEnumExtensions.ToPronoun"/>
    /// </summary>
    [TestCase(99)]
    public void ToPronounThrowsArgumentOutOfRangeExceptionTest(GenderEnum gender)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => gender.ToPronoun());
    }
}