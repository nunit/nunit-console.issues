using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using NUnit.Framework;

namespace WebApi.Tests;

class WebHostStartupFixture
{
    [Test]
    public async Task Should_get_content()
    {
        WebApplicationFactory<WebHostStartup> factory = new();

        using var client = factory.CreateClient();

        var response = await client.GetAsync("/");

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var content = await response.Content.ReadAsStringAsync();

        Assert.That(content, Is.EqualTo("Hello World!"));
    }
}
