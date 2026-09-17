
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutContainersSettingsRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public string? Private { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cdnRegions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsRequestCdnRegion>? CdnRegions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutContainersSettingsRequest" /> class.
        /// </summary>
        /// <param name="private"></param>
        /// <param name="cdnRegions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutContainersSettingsRequest(
            string? @private,
            global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsRequestCdnRegion>? cdnRegions)
        {
            this.Private = @private;
            this.CdnRegions = cdnRegions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutContainersSettingsRequest" /> class.
        /// </summary>
        public PutContainersSettingsRequest()
        {
        }

    }
}