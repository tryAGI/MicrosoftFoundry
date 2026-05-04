namespace MicrosoftFoundry.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MicrosoftFoundryClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MICROSOFT_FOUNDRY_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MICROSOFT_FOUNDRY_API_KEY environment variable is not found.");

        var endpoint =
            Environment.GetEnvironmentVariable("MICROSOFT_FOUNDRY_ENDPOINT") is { Length: > 0 } endpointValue
                ? new Uri(endpointValue)
                : throw new AssertInconclusiveException("MICROSOFT_FOUNDRY_ENDPOINT environment variable is not found.");

        var client = new MicrosoftFoundryClient(apiKey, baseUri: endpoint);
        
        return client;
    }
}
