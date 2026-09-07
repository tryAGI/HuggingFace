
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCollectionsItemsResponseItemVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Note? Note { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gallery")]
        public global::System.Collections.Generic.IList<string>? Gallery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Position { get; set; }

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
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfo? DatasetsServerInfo { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated?> Gated { get; set; }

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
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1ResourceGroup? ResourceGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBenchmark")]
        public bool? IsBenchmark { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTraces")]
        public bool? IsTraces { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseItemVariant1" /> class.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="author"></param>
        /// <param name="id"></param>
        /// <param name="isLikedByUser"></param>
        /// <param name="likes"></param>
        /// <param name="private"></param>
        /// <param name="downloads"></param>
        /// <param name="gated"></param>
        /// <param name="lastModified"></param>
        /// <param name="note"></param>
        /// <param name="gallery"></param>
        /// <param name="datasetsServerInfo"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="isBenchmark"></param>
        /// <param name="isTraces"></param>
        /// <param name="repoType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsItemsResponseItemVariant1(
            double position,
            string author,
            string id,
            bool isLikedByUser,
            double likes,
            bool @private,
            double downloads,
            global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated?> gated,
            global::System.DateTime lastModified,
            global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Note? note,
            global::System.Collections.Generic.IList<string>? gallery,
            global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfo? datasetsServerInfo,
            global::HuggingFace.CreateCollectionsItemsResponseItemVariant1ResourceGroup? resourceGroup,
            bool? isBenchmark,
            bool? isTraces,
            string repoType = "dataset",
            string type = "dataset")
        {
            this.Note = note;
            this.Gallery = gallery;
            this.Position = position;
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
            this.IsTraces = isTraces;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseItemVariant1" /> class.
        /// </summary>
        public CreateCollectionsItemsResponseItemVariant1()
        {
        }

    }
}