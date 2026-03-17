
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request32
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string> Paths { get; set; }

        /// <summary>
        /// Expand the response with the last commit and security file status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<object, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<object, bool?> Expand { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request32" /> class.
        /// </summary>
        /// <param name="paths"></param>
        /// <param name="expand">
        /// Expand the response with the last commit and security file status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request32(
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string> paths,
            global::HuggingFace.AnyOf<object, bool?> expand)
        {
            this.Paths = paths;
            this.Expand = expand;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request32" /> class.
        /// </summary>
        public Request32()
        {
        }
    }
}