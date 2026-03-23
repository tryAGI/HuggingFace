
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsResponseDataItemVariant5
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1, global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1, global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2> Owner { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchCollectionsResponseDataItemVariant5ThemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchCollectionsResponseDataItemVariant5Theme Theme { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant5" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="lastUpdated"></param>
        /// <param name="description"></param>
        /// <param name="owner"></param>
        /// <param name="title"></param>
        /// <param name="theme"></param>
        /// <param name="upvotes"></param>
        /// <param name="isUpvotedByUser"></param>
        /// <param name="shareUrl"></param>
        /// <param name="id"></param>
        /// <param name="numberItems"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsResponseDataItemVariant5(
            string slug,
            global::System.DateTime lastUpdated,
            global::HuggingFace.AnyOf<global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1, global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2> owner,
            string title,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant5Theme theme,
            double upvotes,
            bool isUpvotedByUser,
            string shareUrl,
            string id,
            double numberItems,
            string? description,
            string type = "collection")
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.LastUpdated = lastUpdated;
            this.Owner = owner;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Theme = theme;
            this.Upvotes = upvotes;
            this.IsUpvotedByUser = isUpvotedByUser;
            this.ShareUrl = shareUrl ?? throw new global::System.ArgumentNullException(nameof(shareUrl));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NumberItems = numberItems;
            this.Description = description;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant5" /> class.
        /// </summary>
        public PatchCollectionsResponseDataItemVariant5()
        {
        }
    }
}