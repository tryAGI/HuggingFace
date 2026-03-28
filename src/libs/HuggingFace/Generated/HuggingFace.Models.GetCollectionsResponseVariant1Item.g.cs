
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCollectionsResponseVariant1Item
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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.AnyOf<string, global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2, global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant3>?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<string, global::HuggingFace.AnyOf<string, global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2, global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant3>?> Gating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1, global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1, global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2> Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetCollectionsResponseVariant1ItemThemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetCollectionsResponseVariant1ItemTheme Theme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AllOf<global::HuggingFace.GetCollectionsResponseVariant1ItemItem, global::HuggingFace.AnyOf<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant4, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6>?>> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseVariant1Item" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="lastUpdated"></param>
        /// <param name="gating"></param>
        /// <param name="owner"></param>
        /// <param name="theme"></param>
        /// <param name="private"></param>
        /// <param name="upvotes"></param>
        /// <param name="isUpvotedByUser"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCollectionsResponseVariant1Item(
            string slug,
            string title,
            global::System.DateTime lastUpdated,
            global::HuggingFace.AnyOf<string, global::HuggingFace.AnyOf<string, global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2, global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant3>?> gating,
            global::HuggingFace.AnyOf<global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1, global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2> owner,
            global::HuggingFace.GetCollectionsResponseVariant1ItemTheme theme,
            bool @private,
            double upvotes,
            bool isUpvotedByUser,
            global::System.Collections.Generic.IList<global::HuggingFace.AllOf<global::HuggingFace.GetCollectionsResponseVariant1ItemItem, global::HuggingFace.AnyOf<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant4, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6>?>> items,
            string? description)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.LastUpdated = lastUpdated;
            this.Gating = gating;
            this.Owner = owner;
            this.Theme = theme;
            this.Private = @private;
            this.Upvotes = upvotes;
            this.IsUpvotedByUser = isUpvotedByUser;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseVariant1Item" /> class.
        /// </summary>
        public GetCollectionsResponseVariant1Item()
        {
        }
    }
}