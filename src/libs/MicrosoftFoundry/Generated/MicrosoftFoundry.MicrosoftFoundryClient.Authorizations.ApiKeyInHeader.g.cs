
#nullable enable

namespace MicrosoftFoundry
{
    public sealed partial class MicrosoftFoundryClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "api-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::MicrosoftFoundry.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyApiKey",
                Location = "Header",
                Name = "api-key",
                Value = apiKey,
            });
        }
    }
}