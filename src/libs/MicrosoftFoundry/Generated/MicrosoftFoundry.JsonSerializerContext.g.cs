
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace MicrosoftFoundry
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::MicrosoftFoundry.JsonConverters.OneOfJsonConverter<string, global::MicrosoftFoundry.ErrorDetails>),

            typeof(global::MicrosoftFoundry.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MicrosoftFoundry.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MicrosoftFoundry.GenerateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MicrosoftFoundry.GenerateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MicrosoftFoundry.ImageData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MicrosoftFoundry.ImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MicrosoftFoundry.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MicrosoftFoundry.OneOf<string, global::MicrosoftFoundry.ErrorDetails>), TypeInfoPropertyName = "OneOfStringErrorDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MicrosoftFoundry.ErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MicrosoftFoundry.ImageData>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}