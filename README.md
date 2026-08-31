[![](https://img.shields.io/nuget/v/soenneker.fastly.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.fastly.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.fastly.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.fastly.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.fastly.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.fastly.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.fastly.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.fastly.openapiclient/actions/workflows/codeql.yml)

# Soenneker.Fastly.OpenApiClient

A Kiota-generated .NET client for the Fastly API.

## Installation

```bash
dotnet add package Soenneker.Fastly.OpenApiClient
```

## Create a client

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Fastly.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.fastly.com/")
};
httpClient.DefaultRequestHeaders.Add("Fastly-Key", apiToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new FastlyOpenApiClient(adapter);
```

The HTTP client supplies authentication, so the Kiota adapter uses `AnonymousAuthenticationProvider` to avoid adding a second authorization mechanism.

## Make a request

```csharp
var currentUser = await client.Current_user.GetAsync(
    cancellationToken: cancellationToken);
```

The generated surface follows Fastly's endpoint groups, including `Service`, `Purge`, `Stats`, `Tls`, and `Tokens`. Request and response types live under `Soenneker.Fastly.OpenApiClient.Models`.

The source is generated. Put custom construction and application behavior outside this package so regeneration does not overwrite it. `Soenneker.Fastly.OpenApiClientUtil` provides cached client construction for applications using service registration.
