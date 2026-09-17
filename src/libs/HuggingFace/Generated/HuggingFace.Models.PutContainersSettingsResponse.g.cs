
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutContainersSettingsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cdnRegions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsResponseCdnRegion>? CdnRegions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutContainersSettingsResponse" /> class.
        /// </summary>
        /// <param name="private"></param>
        /// <param name="cdnRegions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutContainersSettingsResponse(
            bool? @private,
            global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsResponseCdnRegion>? cdnRegions)
        {
            this.Private = @private;
            this.CdnRegions = cdnRegions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutContainersSettingsResponse" /> class.
        /// </summary>
        public PutContainersSettingsResponse()
        {
        }

    }
}