
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response119
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.AnyOf<string, global::HuggingFace.ResponseGatingVariant2, global::HuggingFace.ResponseGatingVariant3>?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<string, global::HuggingFace.AnyOf<string, global::HuggingFace.ResponseGatingVariant2, global::HuggingFace.ResponseGatingVariant3>?> Gating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.ResponseOwnerVariant1, global::HuggingFace.ResponseOwnerVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.ResponseOwnerVariant1, global::HuggingFace.ResponseOwnerVariant2> Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseThemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseTheme Theme { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("shareUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareUrl { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.AllOf<global::HuggingFace.ResponseItem22, global::HuggingFace.AnyOf<global::HuggingFace.ResponseItemVariant1, global::HuggingFace.ResponseItemVariant2, global::HuggingFace.ResponseItemVariant3, global::HuggingFace.ResponseItemVariant4, global::HuggingFace.ResponseItemVariant5>?>> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response119" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="lastUpdated"></param>
        /// <param name="gating"></param>
        /// <param name="owner"></param>
        /// <param name="position"></param>
        /// <param name="theme"></param>
        /// <param name="private"></param>
        /// <param name="upvotes"></param>
        /// <param name="shareUrl"></param>
        /// <param name="isUpvotedByUser"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response119(
            string slug,
            string title,
            global::System.DateTime lastUpdated,
            global::HuggingFace.AnyOf<string, global::HuggingFace.AnyOf<string, global::HuggingFace.ResponseGatingVariant2, global::HuggingFace.ResponseGatingVariant3>?> gating,
            global::HuggingFace.AnyOf<global::HuggingFace.ResponseOwnerVariant1, global::HuggingFace.ResponseOwnerVariant2> owner,
            double position,
            global::HuggingFace.ResponseTheme theme,
            bool @private,
            double upvotes,
            string shareUrl,
            bool isUpvotedByUser,
            global::System.Collections.Generic.IList<global::HuggingFace.AllOf<global::HuggingFace.ResponseItem22, global::HuggingFace.AnyOf<global::HuggingFace.ResponseItemVariant1, global::HuggingFace.ResponseItemVariant2, global::HuggingFace.ResponseItemVariant3, global::HuggingFace.ResponseItemVariant4, global::HuggingFace.ResponseItemVariant5>?>> items,
            string? description)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.LastUpdated = lastUpdated;
            this.Gating = gating;
            this.Owner = owner;
            this.Position = position;
            this.Theme = theme;
            this.Private = @private;
            this.Upvotes = upvotes;
            this.ShareUrl = shareUrl ?? throw new global::System.ArgumentNullException(nameof(shareUrl));
            this.IsUpvotedByUser = isUpvotedByUser;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response119" /> class.
        /// </summary>
        public Response119()
        {
        }
    }
}