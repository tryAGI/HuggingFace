
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request53
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromRepo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromRepo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toRepo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToRepo { get; set; }

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestTypeJsonConverter))]
        public global::HuggingFace.RequestType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request53" /> class.
        /// </summary>
        /// <param name="fromRepo"></param>
        /// <param name="toRepo"></param>
        /// <param name="type">
        /// Default Value: model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request53(
            string fromRepo,
            string toRepo,
            global::HuggingFace.RequestType? type)
        {
            this.FromRepo = fromRepo ?? throw new global::System.ArgumentNullException(nameof(fromRepo));
            this.ToRepo = toRepo ?? throw new global::System.ArgumentNullException(nameof(toRepo));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request53" /> class.
        /// </summary>
        public Request53()
        {
        }
    }
}