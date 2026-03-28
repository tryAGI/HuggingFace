
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsResponseDataItemVariant3RuntimeReplicas
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        public double? Current { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<double?, string> Requested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant3RuntimeReplicas" /> class.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="requested"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsResponseDataItemVariant3RuntimeReplicas(
            global::HuggingFace.AnyOf<double?, string> requested,
            double? current)
        {
            this.Requested = requested;
            this.Current = current;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant3RuntimeReplicas" /> class.
        /// </summary>
        public PatchCollectionsResponseDataItemVariant3RuntimeReplicas()
        {
        }
    }
}