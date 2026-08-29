<div class="docs-hero">
  <h1>MicrosoftFoundry</h1>
  <p class="docs-hero-lead">Modern .NET SDK for MicrosoftFoundry generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/MicrosoftFoundry/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/MicrosoftFoundry"></a>
    <a href="https://github.com/tryAGI/MicrosoftFoundry/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/MicrosoftFoundry/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/MicrosoftFoundry/blob/main/LICENSE"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/MicrosoftFoundry"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="src/libs/MicrosoftFoundry/openapi.yaml">Microsoft Foundry's OpenAPI definition</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using MicrosoftFoundry;

using var client = new MicrosoftFoundryClient(apiKey);
```

<!-- EXAMPLES:START -->
### Generate image
Generate an image with a deployed Microsoft Foundry MAI image model.

```csharp
var apiKey =
    Environment.GetEnvironmentVariable("MICROSOFT_FOUNDRY_API_KEY") is { Length: > 0 } apiKeyValue
        ? apiKeyValue
        : throw new AssertInconclusiveException("MICROSOFT_FOUNDRY_API_KEY environment variable is not found.");

var endpoint =
    Environment.GetEnvironmentVariable("MICROSOFT_FOUNDRY_ENDPOINT") is { Length: > 0 } endpointValue
        ? new Uri(endpointValue)
        : throw new AssertInconclusiveException("MICROSOFT_FOUNDRY_ENDPOINT environment variable is not found.");

using var client = new MicrosoftFoundryClient(apiKey, baseUri: endpoint);

var deploymentName =
    Environment.GetEnvironmentVariable("MICROSOFT_FOUNDRY_IMAGE_DEPLOYMENT") is { Length: > 0 } deploymentValue
        ? deploymentValue
        : "mai-image-2";

var response = await client.GenerateImageAsync(
    model: deploymentName,
    prompt: "A photorealistic image of a mountain lake at sunrise.",
    width: 1024,
    height: 1024);
```
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/MicrosoftFoundry/issues">tryAGI/MicrosoftFoundry</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/MicrosoftFoundry/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
