
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace MicrosoftFoundry
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::MicrosoftFoundry.GenerateImageRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MicrosoftFoundry.GenerateImageResponse? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MicrosoftFoundry.ImageData>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MicrosoftFoundry.ImageData? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MicrosoftFoundry.ErrorResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MicrosoftFoundry.OneOf<string, global::MicrosoftFoundry.ErrorDetails>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MicrosoftFoundry.ErrorDetails? Type9 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MicrosoftFoundry.ImageData>? ListType0 { get; set; }
    }
}