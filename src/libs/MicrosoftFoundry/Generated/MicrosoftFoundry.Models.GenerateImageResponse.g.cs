
#nullable enable

namespace MicrosoftFoundry
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageResponse
    {
        /// <summary>
        /// Unix timestamp for the generation response, when returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MicrosoftFoundry.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Generated image outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MicrosoftFoundry.ImageData> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Generated image outputs.
        /// </param>
        /// <param name="created">
        /// Unix timestamp for the generation response, when returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageResponse(
            global::System.Collections.Generic.IList<global::MicrosoftFoundry.ImageData> data,
            global::System.DateTimeOffset? created)
        {
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageResponse" /> class.
        /// </summary>
        public GenerateImageResponse()
        {
        }
    }
}