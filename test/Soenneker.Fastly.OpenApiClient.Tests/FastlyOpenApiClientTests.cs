using Soenneker.Tests.HostedUnit;

namespace Soenneker.Fastly.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FastlyOpenApiClientTests : HostedUnitTest
{
    public FastlyOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
