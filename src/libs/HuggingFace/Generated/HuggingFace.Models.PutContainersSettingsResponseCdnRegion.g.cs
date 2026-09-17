
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutContainersSettingsResponseCdnRegion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PutContainersSettingsResponseCdnRegionProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PutContainersSettingsResponseCdnRegionRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutContainersSettingsResponseCdnRegion" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutContainersSettingsResponseCdnRegion(
            global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider provider,
            global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion region)
        {
            this.Provider = provider;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutContainersSettingsResponseCdnRegion" /> class.
        /// </summary>
        public PutContainersSettingsResponseCdnRegion()
        {
        }

    }
}