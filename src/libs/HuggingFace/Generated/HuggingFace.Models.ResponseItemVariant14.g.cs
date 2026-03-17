
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemVariant14
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
        public global::HuggingFace.ResponseItemVariant1DatasetsServerInfo4? DatasetsServerInfo { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.ResponseItemVariant1GatedEnum8?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<string, global::HuggingFace.ResponseItemVariant1GatedEnum8?> Gated { get; set; }

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
        public global::HuggingFace.ResponseItemVariant1ResourceGroup4? ResourceGroup { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseItemVariant14" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="id"></param>
        /// <param name="isLikedByUser"></param>
        /// <param name="likes"></param>
        /// <param name="datasetsServerInfo"></param>
        /// <param name="private"></param>
        /// <param name="repoType"></param>
        /// <param name="downloads"></param>
        /// <param name="gated"></param>
        /// <param name="lastModified"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="isBenchmark"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemVariant14(
            string author,
            string id,
            bool isLikedByUser,
            double likes,
            bool @private,
            double downloads,
            global::HuggingFace.AnyOf<string, global::HuggingFace.ResponseItemVariant1GatedEnum8?> gated,
            global::System.DateTime lastModified,
            global::HuggingFace.ResponseItemVariant1DatasetsServerInfo4? datasetsServerInfo,
            global::HuggingFace.ResponseItemVariant1ResourceGroup4? resourceGroup,
            bool? isBenchmark,
            string repoType = "dataset",
            string type = "dataset")
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsLikedByUser = isLikedByUser;
            this.Likes = likes;
            this.Private = @private;
            this.Downloads = downloads;
            this.Gated = gated;
            this.LastModified = lastModified;
            this.DatasetsServerInfo = datasetsServerInfo;
            this.RepoType = repoType;
            this.ResourceGroup = resourceGroup;
            this.IsBenchmark = isBenchmark;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant14" /> class.
        /// </summary>
        public ResponseItemVariant14()
        {
        }
    }
}