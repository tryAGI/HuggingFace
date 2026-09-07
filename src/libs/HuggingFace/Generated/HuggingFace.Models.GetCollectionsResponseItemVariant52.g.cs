
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetCollectionsResponseItemVariant52
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public global::HuggingFace.GetCollectionsResponseItemVariant5Note2? Note { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant12, global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant22>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant12, global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant22> Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetCollectionsResponseItemVariant5Theme2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetCollectionsResponseItemVariant5Theme2 Theme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upvotes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Upvotes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isUpvotedByUser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsUpvotedByUser { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumberItems { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"collection"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "collection";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseItemVariant52" /> class.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="slug"></param>
        /// <param name="lastUpdated"></param>
        /// <param name="owner"></param>
        /// <param name="title"></param>
        /// <param name="theme"></param>
        /// <param name="upvotes"></param>
        /// <param name="isUpvotedByUser"></param>
        /// <param name="shareUrl"></param>
        /// <param name="id"></param>
        /// <param name="numberItems"></param>
        /// <param name="note"></param>
        /// <param name="gallery"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCollectionsResponseItemVariant52(
            double position,
            string slug,
            global::System.DateTime lastUpdated,
            global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant12, global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant22> owner,
            string title,
            global::HuggingFace.GetCollectionsResponseItemVariant5Theme2 theme,
            double upvotes,
            bool isUpvotedByUser,
            string shareUrl,
            string id,
            double numberItems,
            global::HuggingFace.GetCollectionsResponseItemVariant5Note2? note,
            global::System.Collections.Generic.IList<string>? gallery,
            string? description,
            string type = "collection")
        {
            this.Note = note;
            this.Gallery = gallery;
            this.Position = position;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.LastUpdated = lastUpdated;
            this.Description = description;
            this.Owner = owner;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Theme = theme;
            this.Upvotes = upvotes;
            this.IsUpvotedByUser = isUpvotedByUser;
            this.ShareUrl = shareUrl ?? throw new global::System.ArgumentNullException(nameof(shareUrl));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NumberItems = numberItems;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseItemVariant52" /> class.
        /// </summary>
        public GetCollectionsResponseItemVariant52()
        {
        }

    }
}