# Generate image

Generate an image with a deployed Microsoft Foundry MAI image model.

This example assumes `using MicrosoftFoundry;` is in scope and `apiKey` contains your MicrosoftFoundry API key.

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