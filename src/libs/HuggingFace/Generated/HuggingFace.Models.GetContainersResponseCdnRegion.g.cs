
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetContainersResponseCdnRegion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetContainersResponseCdnRegionProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetContainersResponseCdnRegionProvider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetContainersResponseCdnRegionRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetContainersResponseCdnRegionRegion Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContainersResponseCdnRegion" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetContainersResponseCdnRegion(
            global::HuggingFace.GetContainersResponseCdnRegionProvider provider,
            global::HuggingFace.GetContainersResponseCdnRegionRegion region)
        {
            this.Provider = provider;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContainersResponseCdnRegion" /> class.
        /// </summary>
        public GetContainersResponseCdnRegion()
        {
        }

    }
}