
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Bucket creation options
    /// </summary>
    public sealed partial class CreateContainersRequest
    {
        /// <summary>
        /// Bucket visibility. Defaults to public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// CDN pre-warming regions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cdn")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersRequestCdnItem>? Cdn { get; set; }

        /// <summary>
        /// The region where the bucket is hosted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateContainersRequestRegionJsonConverter))]
        public global::HuggingFace.CreateContainersRequestRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainersRequest" /> class.
        /// </summary>
        /// <param name="private">
        /// Bucket visibility. Defaults to public
        /// </param>
        /// <param name="resourceGroupId"></param>
        /// <param name="cdn">
        /// CDN pre-warming regions
        /// </param>
        /// <param name="region">
        /// The region where the bucket is hosted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContainersRequest(
            bool? @private,
            string? resourceGroupId,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersRequestCdnItem>? cdn,
            global::HuggingFace.CreateContainersRequestRegion? region)
        {
            this.Private = @private;
            this.ResourceGroupId = resourceGroupId;
            this.Cdn = cdn;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainersRequest" /> class.
        /// </summary>
        public CreateContainersRequest()
        {
        }

    }
}