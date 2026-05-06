
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutBucketsSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, object>))]
        public global::HuggingFace.AnyOf<bool?, object>? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cdnRegions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.PutBucketsSettingsRequestCdnRegion> CdnRegions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutBucketsSettingsRequest" /> class.
        /// </summary>
        /// <param name="cdnRegions"></param>
        /// <param name="private"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutBucketsSettingsRequest(
            global::System.Collections.Generic.IList<global::HuggingFace.PutBucketsSettingsRequestCdnRegion> cdnRegions,
            global::HuggingFace.AnyOf<bool?, object>? @private)
        {
            this.Private = @private;
            this.CdnRegions = cdnRegions ?? throw new global::System.ArgumentNullException(nameof(cdnRegions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutBucketsSettingsRequest" /> class.
        /// </summary>
        public PutBucketsSettingsRequest()
        {
        }
    }
}