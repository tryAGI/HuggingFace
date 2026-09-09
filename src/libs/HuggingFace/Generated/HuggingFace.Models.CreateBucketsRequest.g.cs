
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Bucket creation options
    /// </summary>
    public sealed partial class CreateBucketsRequest
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
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsRequestCdnItem>? Cdn { get; set; }

        /// <summary>
        /// The region where the bucket is hosted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateBucketsRequestRegionJsonConverter))]
        public global::HuggingFace.CreateBucketsRequestRegion? Region { get; set; }

        /// <summary>
        /// Create a container (Docker image) repository usable with the HF container registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        public bool? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBucketsRequest" /> class.
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
        /// <param name="container">
        /// Create a container (Docker image) repository usable with the HF container registry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBucketsRequest(
            bool? @private,
            string? resourceGroupId,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsRequestCdnItem>? cdn,
            global::HuggingFace.CreateBucketsRequestRegion? region,
            bool? container)
        {
            this.Private = @private;
            this.ResourceGroupId = resourceGroupId;
            this.Cdn = cdn;
            this.Region = region;
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBucketsRequest" /> class.
        /// </summary>
        public CreateBucketsRequest()
        {
        }

    }
}