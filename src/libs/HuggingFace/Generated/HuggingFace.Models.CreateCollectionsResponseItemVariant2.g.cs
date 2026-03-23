
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsResponseItemVariant2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Downloads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableInferenceProviders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProvider> AvailableInferenceProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isLikedByUser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLikedByUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Likes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_tag")]
        public string? PipelineTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"model"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoType")]
        public string RepoType { get; set; } = "model";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.CreateCollectionsResponseItemVariant2GatedEnum2?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<string, global::HuggingFace.CreateCollectionsResponseItemVariant2GatedEnum2?> Gated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroup")]
        public global::HuggingFace.CreateCollectionsResponseItemVariant2ResourceGroup? ResourceGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numParameters")]
        public double? NumParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorData")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant1, global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant1, global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2>? AuthorData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widgetOutputUrls")]
        public global::System.Collections.Generic.IList<string>? WidgetOutputUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"model"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "model";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseItemVariant2" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="downloads"></param>
        /// <param name="id"></param>
        /// <param name="availableInferenceProviders"></param>
        /// <param name="isLikedByUser"></param>
        /// <param name="lastModified"></param>
        /// <param name="likes"></param>
        /// <param name="pipelineTag"></param>
        /// <param name="private"></param>
        /// <param name="repoType"></param>
        /// <param name="gated"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="numParameters"></param>
        /// <param name="authorData"></param>
        /// <param name="widgetOutputUrls"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsResponseItemVariant2(
            string author,
            double downloads,
            string id,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProvider> availableInferenceProviders,
            bool isLikedByUser,
            global::System.DateTime lastModified,
            double likes,
            bool @private,
            global::HuggingFace.AnyOf<string, global::HuggingFace.CreateCollectionsResponseItemVariant2GatedEnum2?> gated,
            string? pipelineTag,
            global::HuggingFace.CreateCollectionsResponseItemVariant2ResourceGroup? resourceGroup,
            double? numParameters,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant1, global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2>? authorData,
            global::System.Collections.Generic.IList<string>? widgetOutputUrls,
            string repoType = "model",
            string type = "model")
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Downloads = downloads;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AvailableInferenceProviders = availableInferenceProviders ?? throw new global::System.ArgumentNullException(nameof(availableInferenceProviders));
            this.IsLikedByUser = isLikedByUser;
            this.LastModified = lastModified;
            this.Likes = likes;
            this.Private = @private;
            this.Gated = gated;
            this.PipelineTag = pipelineTag;
            this.RepoType = repoType;
            this.ResourceGroup = resourceGroup;
            this.NumParameters = numParameters;
            this.AuthorData = authorData;
            this.WidgetOutputUrls = widgetOutputUrls;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseItemVariant2" /> class.
        /// </summary>
        public CreateCollectionsResponseItemVariant2()
        {
        }
    }
}