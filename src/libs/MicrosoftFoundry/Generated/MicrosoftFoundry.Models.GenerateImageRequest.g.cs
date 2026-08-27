
#nullable enable

namespace MicrosoftFoundry
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateImageRequest
    {
        /// <summary>
        /// Deployment name assigned when deploying MAI-Image-2 or MAI-Image-2e.<br/>
        /// Example: mai-image-2
        /// </summary>
        /// <example>mai-image-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Text prompt describing the image to generate.<br/>
        /// Example: A photorealistic image of a mountain lake at sunrise
        /// </summary>
        /// <example>A photorealistic image of a mountain lake at sunrise</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Output image width in pixels.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Output image height in pixels.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Deployment name assigned when deploying MAI-Image-2 or MAI-Image-2e.<br/>
        /// Example: mai-image-2
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the image to generate.<br/>
        /// Example: A photorealistic image of a mountain lake at sunrise
        /// </param>
        /// <param name="width">
        /// Output image width in pixels.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="height">
        /// Output image height in pixels.<br/>
        /// Example: 1024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequest(
            string model,
            string prompt,
            int width,
            int height)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        public GenerateImageRequest()
        {
        }

    }
}