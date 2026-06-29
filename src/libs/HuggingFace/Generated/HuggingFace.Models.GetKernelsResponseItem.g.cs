
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKernelsResponseItem
    {
        /// <summary>
        /// Kernel ID in format namespace/name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Namespace (user or organization) of the kernel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Whether the kernel is private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Kernel card metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardData")]
        public object? CardData { get; set; }

        /// <summary>
        /// Whether the kernel is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Number of downloads in the last 30 days
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads")]
        public int? Downloads { get; set; }

        /// <summary>
        /// Total number of downloads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadsAllTime")]
        public int? DownloadsAllTime { get; set; }

        /// <summary>
        /// Gated access status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string, string>))]
        public global::HuggingFace.AnyOf<bool?, string, string>? Gated { get; set; }

        /// <summary>
        /// Last modification timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        public global::System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Number of likes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likes")]
        public int? Likes { get; set; }

        /// <summary>
        /// Current commit SHA
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// List of files in the kernel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<string>? Files { get; set; }

        /// <summary>
        /// Kernel tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Trending score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trendingScore")]
        public double? TrendingScore { get; set; }

        /// <summary>
        /// Build metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMetadata")]
        public global::HuggingFace.GetKernelsResponseItemBuildMetadata? BuildMetadata { get; set; }

        /// <summary>
        /// Driver families supported by the kernel (derived from build metadata)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedDriverFamilies")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie>? SupportedDriverFamilies { get; set; }

        /// <summary>
        /// Resource group information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroup")]
        public global::HuggingFace.GetKernelsResponseItemResourceGroup? ResourceGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Kernel ID in format namespace/name
        /// </param>
        /// <param name="author">
        /// Namespace (user or organization) of the kernel
        /// </param>
        /// <param name="private">
        /// Whether the kernel is private
        /// </param>
        /// <param name="cardData">
        /// Kernel card metadata
        /// </param>
        /// <param name="disabled">
        /// Whether the kernel is disabled
        /// </param>
        /// <param name="downloads">
        /// Number of downloads in the last 30 days
        /// </param>
        /// <param name="downloadsAllTime">
        /// Total number of downloads
        /// </param>
        /// <param name="gated">
        /// Gated access status
        /// </param>
        /// <param name="lastModified">
        /// Last modification timestamp
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="likes">
        /// Number of likes
        /// </param>
        /// <param name="sha">
        /// Current commit SHA
        /// </param>
        /// <param name="files">
        /// List of files in the kernel
        /// </param>
        /// <param name="tags">
        /// Kernel tags
        /// </param>
        /// <param name="trendingScore">
        /// Trending score
        /// </param>
        /// <param name="buildMetadata">
        /// Build metadata
        /// </param>
        /// <param name="supportedDriverFamilies">
        /// Driver families supported by the kernel (derived from build metadata)
        /// </param>
        /// <param name="resourceGroup">
        /// Resource group information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKernelsResponseItem(
            string id,
            string? author,
            bool? @private,
            object? cardData,
            bool? disabled,
            int? downloads,
            int? downloadsAllTime,
            global::HuggingFace.AnyOf<bool?, string, string>? gated,
            global::System.DateTime? lastModified,
            global::System.DateTime? createdAt,
            int? likes,
            string? sha,
            global::System.Collections.Generic.IList<string>? files,
            global::System.Collections.Generic.IList<string>? tags,
            double? trendingScore,
            global::HuggingFace.GetKernelsResponseItemBuildMetadata? buildMetadata,
            global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie>? supportedDriverFamilies,
            global::HuggingFace.GetKernelsResponseItemResourceGroup? resourceGroup)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Author = author;
            this.Private = @private;
            this.CardData = cardData;
            this.Disabled = disabled;
            this.Downloads = downloads;
            this.DownloadsAllTime = downloadsAllTime;
            this.Gated = gated;
            this.LastModified = lastModified;
            this.CreatedAt = createdAt;
            this.Likes = likes;
            this.Sha = sha;
            this.Files = files;
            this.Tags = tags;
            this.TrendingScore = trendingScore;
            this.BuildMetadata = buildMetadata;
            this.SupportedDriverFamilies = supportedDriverFamilies;
            this.ResourceGroup = resourceGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponseItem" /> class.
        /// </summary>
        public GetKernelsResponseItem()
        {
        }

    }
}