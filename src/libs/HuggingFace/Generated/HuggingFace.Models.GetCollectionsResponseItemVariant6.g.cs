
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCollectionsResponseItemVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The amount of storage used by the bucket in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// The total number of files in the bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalFiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"bucket"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoType")]
        public string RepoType { get; set; } = "bucket";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cdnRegions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion> CdnRegions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroup")]
        public global::HuggingFace.GetCollectionsResponseItemVariant6ResourceGroup? ResourceGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"bucket"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "bucket";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseItemVariant6" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="id"></param>
        /// <param name="private"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="size">
        /// The amount of storage used by the bucket in bytes
        /// </param>
        /// <param name="totalFiles">
        /// The total number of files in the bucket
        /// </param>
        /// <param name="repoType"></param>
        /// <param name="cdnRegions"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCollectionsResponseItemVariant6(
            string author,
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            double size,
            double totalFiles,
            global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion> cdnRegions,
            bool? @private,
            global::HuggingFace.GetCollectionsResponseItemVariant6ResourceGroup? resourceGroup,
            string repoType = "bucket",
            string type = "bucket")
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Size = size;
            this.TotalFiles = totalFiles;
            this.CdnRegions = cdnRegions ?? throw new global::System.ArgumentNullException(nameof(cdnRegions));
            this.Private = @private;
            this.RepoType = repoType;
            this.ResourceGroup = resourceGroup;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseItemVariant6" /> class.
        /// </summary>
        public GetCollectionsResponseItemVariant6()
        {
        }
    }
}