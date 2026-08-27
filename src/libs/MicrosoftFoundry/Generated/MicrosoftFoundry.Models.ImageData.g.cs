
#nullable enable

namespace MicrosoftFoundry
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageData
    {
        /// <summary>
        /// Base64 encoded PNG image data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64Json { get; set; }

        /// <summary>
        /// Revised prompt, when returned by the service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revised_prompt")]
        public string? RevisedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// Base64 encoded PNG image data.
        /// </param>
        /// <param name="revisedPrompt">
        /// Revised prompt, when returned by the service.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageData(
            string b64Json,
            string? revisedPrompt)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.RevisedPrompt = revisedPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        public ImageData()
        {
        }

    }
}