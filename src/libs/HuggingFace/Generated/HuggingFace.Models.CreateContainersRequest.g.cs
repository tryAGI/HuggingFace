
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Bucket creation options
    /// </summary>
    public sealed partial class CreateContainersRequest
    {
        /// <summary>
        /// Bucket visibility. Defaults to public. Cannot be specified along with visibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Bucket visibility. Cannot be specified along with private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateContainersRequestVisibilityJsonConverter))]
        public global::HuggingFace.CreateContainersRequestVisibility? Visibility { get; set; }

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
        /// Free-text description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainersRequest" /> class.
        /// </summary>
        /// <param name="private">
        /// Bucket visibility. Defaults to public. Cannot be specified along with visibility.
        /// </param>
        /// <param name="visibility">
        /// Bucket visibility. Cannot be specified along with private.
        /// </param>
        /// <param name="resourceGroupId"></param>
        /// <param name="cdn">
        /// CDN pre-warming regions
        /// </param>
        /// <param name="region">
        /// The region where the bucket is hosted.
        /// </param>
        /// <param name="description">
        /// Free-text description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContainersRequest(
            bool? @private,
            global::HuggingFace.CreateContainersRequestVisibility? visibility,
            string? resourceGroupId,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersRequestCdnItem>? cdn,
            global::HuggingFace.CreateContainersRequestRegion? region,
            string? description)
        {
            this.Private = @private;
            this.Visibility = visibility;
            this.ResourceGroupId = resourceGroupId;
            this.Cdn = cdn;
            this.Region = region;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainersRequest" /> class.
        /// </summary>
        public CreateContainersRequest()
        {
        }

    }
}