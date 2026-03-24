using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Fastly.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class FastlyOpenApiClientTests : FixturedUnitTest
{
    public FastlyOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
