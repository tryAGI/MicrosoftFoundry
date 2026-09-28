
#nullable enable

namespace MicrosoftFoundry
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::MicrosoftFoundry.JsonConverters.OneOfJsonConverter<string, global::MicrosoftFoundry.ErrorDetails>),

            typeof(global::MicrosoftFoundry.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MicrosoftFoundry.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
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