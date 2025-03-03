using NUnit.Framework;
using ToennVaot.Components.Core.Api.Extensions.Tests.Mocks;
using ToennVaot.Components.Core.Api.Models.Hal;
using Assert = NUnit.Framework.Assert;

namespace ToennVaot.Components.Core.Api.Extensions.Tests;

/// <summary>
/// The unit test class for <see cref="RepresentationExtensions"/>
/// </summary>
public class RepresentationExtensionsTests
{
    /// <summary>
    /// Set up the unit test class
    /// </summary>
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddSelfRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddSelfRelationTest()
    {
        var x = new FakeRepresentation();
        x.AddSelfRelation(new Link { Href = "http://self.uri", Method = HttpMethod.Get, Name = "Self URI", Rel = "test self"});
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://self.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Name == "Self URI");
        Assert.That(x.Links.First().Value.Rel == "self");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddSelfRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddSelfRelationSimplifiedCallTest()
    {
        var x = new FakeRepresentation();
        x.AddSelfRelation("http://self.uri", HttpMethod.Get);
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://self.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Rel == "self");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddSearchRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddSearchRelationTest()
    {
        var x = new FakeRepresentation();
        x.AddSearchRelation(new Link { Href = "http://search.uri", Method = HttpMethod.Get, Name = "Search URI", Rel = "test search"});
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://search.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Name == "Search URI");
        Assert.That(x.Links.First().Value.Rel == "search");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddSearchRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddSearchRelationSimplifiedCallTest()
    {
        var x = new FakeRepresentation();
        x.AddSearchRelation("http://search.uri", HttpMethod.Get);
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://search.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Rel == "search");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddFirstRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddFirstRelationTest()
    {
        var x = new FakeRepresentation();
        x.AddFirstRelation(new Link { Href = "http://first.uri", Method = HttpMethod.Get, Name = "First URI", Rel = "test first"});
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://first.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Name == "First URI");
        Assert.That(x.Links.First().Value.Rel == "first");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddFirstRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddFirstRelationSimplifiedCallTest()
    {
        var x = new FakeRepresentation();
        x.AddFirstRelation("http://first.uri", HttpMethod.Get);
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://first.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Rel == "first");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddPreviousRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddPreviousRelationTest()
    {
        var x = new FakeRepresentation();
        x.AddPreviousRelation(new Link { Href = "http://previous.uri", Method = HttpMethod.Get, Name = "Previous URI", Rel = "test previous"});
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://previous.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Name == "Previous URI");
        Assert.That(x.Links.First().Value.Rel == "previous");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddPreviousRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddPreviousRelationSimplifiedCallTest()
    {
        var x = new FakeRepresentation();
        x.AddPreviousRelation("http://previous.uri", HttpMethod.Get);
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://previous.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Rel == "previous");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddNextRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddNextRelationTest()
    {
        var x = new FakeRepresentation();
        x.AddNextRelation(new Link { Href = "http://next.uri", Method = HttpMethod.Get, Name = "Next URI", Rel = "test next" });
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://next.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Name == "Next URI");
        Assert.That(x.Links.First().Value.Rel == "next");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddNextRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddNextRelationSimplifiedCallTest()
    {
        var x = new FakeRepresentation();
        x.AddNextRelation("http://next.uri", HttpMethod.Get);
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://next.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Rel == "next");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddRelationTest()
    {
        var x = new FakeRepresentation();
        x.AddRelation(new Link { Href = "http://about.uri", Method = HttpMethod.Get, Name = "About URI", Rel = "test about"}, "about");
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://about.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Name == "About URI");
        Assert.That(x.Links.First().Value.Rel == "about");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddNextRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddRelationSimplifiedCallTest()
    {
        var x = new FakeRepresentation();
        x.AddRelation("about", "http://about.uri", HttpMethod.Get);
        Assert.That(x.Links.Count > 0);
        Assert.That(x.Links.First().Value.Href == "http://about.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Rel == "about");
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddRelationThrowsArgumentExceptionWithNullRelTest()
    {
        var x = new FakeRepresentation();
        Assert.Throws<ArgumentNullException>(() => x.AddRelation(new Link { Href = "http://about.uri", Method = HttpMethod.Get, Name = "About URI", Rel = "test about" }, null));
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddRelationThrowsArgumentExceptionWithEmptyRelTest()
    {
        var x = new FakeRepresentation();
        Assert.Throws<ArgumentNullException>(() => x.AddRelation(new Link { Href = "http://about.uri", Method = HttpMethod.Get, Name = "About URI", Rel = "test about" }, string.Empty));
    }

    /// <summary>
    /// Test <see cref="RepresentationExtensions.AddNextRelation(ToennVaot.Components.Core.Api.Models.Hal.Representation,string,System.Net.Http.HttpMethod)"/> method
    /// </summary>
    [Test]
    public void AddRelationWhenAlreadyHaveOneOnSameRelTest()
    {
        var x = new FakeRepresentation();
        x.AddRelation("about", "http://about.uri", HttpMethod.Get);
        Assert.That(x.Links.Count == 1);
        Assert.That(x.Links.First().Value.Href == "http://about.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Rel == "about");
        x.AddRelation("about", "http://about2.uri", HttpMethod.Get);
        Assert.That(x.Links.Count == 1);
        Assert.That(x.Links.First().Value.Href == "http://about2.uri");
        Assert.That(x.Links.First().Value.Method == HttpMethod.Get);
        Assert.That(x.Links.First().Value.HttpMethod == HttpMethod.Get.Method);
        Assert.That(x.Links.First().Value.Rel == "about");
    }
}
