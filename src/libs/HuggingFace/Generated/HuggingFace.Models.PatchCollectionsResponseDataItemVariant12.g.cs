
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsResponseDataItemVariant12
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
        [global::System.Text.Json.Serialization.JsonPropertyName("isLikedByUser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLikedByUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Likes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetsServerInfo")]
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2? DatasetsServerInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"dataset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoType")]
        public string RepoType { get; set; } = "dataset";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Downloads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.PatchCollectionsResponseDataItemVariant1GatedEnum4?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<string, global::HuggingFace.PatchCollectionsResponseDataItemVariant1GatedEnum4?> Gated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroup")]
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1ResourceGroup2? ResourceGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBenchmark")]
        public bool? IsBenchmark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"dataset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "dataset";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant12" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="id"></param>
        /// <param name="isLikedByUser"></param>
        /// <param name="likes"></param>
        /// <param name="private"></param>
        /// <param name="downloads"></param>
        /// <param name="gated"></param>
        /// <param name="lastModified"></param>
        /// <param name="datasetsServerInfo"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="isBenchmark"></param>
        /// <param name="repoType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsResponseDataItemVariant12(
            string author,
            string id,
            bool isLikedByUser,
            double likes,
            bool @private,
            double downloads,
            global::HuggingFace.AnyOf<string, global::HuggingFace.PatchCollectionsResponseDataItemVariant1GatedEnum4?> gated,
            global::System.DateTime lastModified,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2? datasetsServerInfo,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant1ResourceGroup2? resourceGroup,
            bool? isBenchmark,
            string repoType = "dataset",
            string type = "dataset")
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsLikedByUser = isLikedByUser;
            this.Likes = likes;
            this.DatasetsServerInfo = datasetsServerInfo;
            this.Private = @private;
            this.RepoType = repoType;
            this.Downloads = downloads;
            this.Gated = gated;
            this.LastModified = lastModified;
            this.ResourceGroup = resourceGroup;
            this.IsBenchmark = isBenchmark;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant12" /> class.
        /// </summary>
        public PatchCollectionsResponseDataItemVariant12()
        {
        }
    }
}