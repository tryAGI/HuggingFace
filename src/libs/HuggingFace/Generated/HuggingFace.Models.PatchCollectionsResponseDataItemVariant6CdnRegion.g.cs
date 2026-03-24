
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsResponseDataItemVariant6CdnRegion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchCollectionsResponseDataItemVariant6CdnRegionProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchCollectionsResponseDataItemVariant6CdnRegionRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionRegion Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant6CdnRegion" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsResponseDataItemVariant6CdnRegion(
            global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionProvider provider,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionRegion region)
        {
            this.Provider = provider;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant6CdnRegion" /> class.
        /// </summary>
        public PatchCollectionsResponseDataItemVariant6CdnRegion()
        {
        }
    }
}