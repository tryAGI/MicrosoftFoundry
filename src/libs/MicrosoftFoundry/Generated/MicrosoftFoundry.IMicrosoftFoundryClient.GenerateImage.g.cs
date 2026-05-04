#nullable enable

namespace MicrosoftFoundry
{
    public partial interface IMicrosoftFoundryClient
    {
        /// <summary>
        /// Generate image<br/>
        /// Generate a PNG image using a deployed MAI image generation model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MicrosoftFoundry.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MicrosoftFoundry.GenerateImageResponse> GenerateImageAsync(

            global::MicrosoftFoundry.GenerateImageRequest request,
            global::MicrosoftFoundry.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image<br/>
        /// Generate a PNG image using a deployed MAI image generation model.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MicrosoftFoundry.GenerateImageResponse> GenerateImageAsync(
            string model,
            string prompt,
            int width,
            int height,
            global::MicrosoftFoundry.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}