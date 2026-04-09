
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKernelsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"kernel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoType")]
        public string RepoType { get; set; } = "kernel";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.GetKernelsResponseGatedEnum2?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<string, global::HuggingFace.GetKernelsResponseGatedEnum2?> Gated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroup")]
        public global::HuggingFace.GetKernelsResponseResourceGroup? ResourceGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorData")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetKernelsResponseAuthorDataVariant1, global::HuggingFace.GetKernelsResponseAuthorDataVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsResponseAuthorDataVariant1, global::HuggingFace.GetKernelsResponseAuthorDataVariant2>? AuthorData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<string>? Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedDriverFamilies")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseSupportedDriverFamilie>? SupportedDriverFamilies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponse" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="downloads"></param>
        /// <param name="id"></param>
        /// <param name="isLikedByUser"></param>
        /// <param name="lastModified"></param>
        /// <param name="likes"></param>
        /// <param name="private"></param>
        /// <param name="sha"></param>
        /// <param name="gated"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="authorData"></param>
        /// <param name="files"></param>
        /// <param name="supportedDriverFamilies"></param>
        /// <param name="repoType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKernelsResponse(
            string author,
            double downloads,
            string id,
            bool isLikedByUser,
            global::System.DateTime lastModified,
            double likes,
            bool @private,
            string sha,
            global::HuggingFace.AnyOf<string, global::HuggingFace.GetKernelsResponseGatedEnum2?> gated,
            global::HuggingFace.GetKernelsResponseResourceGroup? resourceGroup,
            global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsResponseAuthorDataVariant1, global::HuggingFace.GetKernelsResponseAuthorDataVariant2>? authorData,
            global::System.Collections.Generic.IList<string>? files,
            global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseSupportedDriverFamilie>? supportedDriverFamilies,
            string repoType = "kernel")
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Downloads = downloads;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsLikedByUser = isLikedByUser;
            this.LastModified = lastModified;
            this.Likes = likes;
            this.Private = @private;
            this.RepoType = repoType;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Gated = gated;
            this.ResourceGroup = resourceGroup;
            this.AuthorData = authorData;
            this.Files = files;
            this.SupportedDriverFamilies = supportedDriverFamilies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKernelsResponse" /> class.
        /// </summary>
        public GetKernelsResponse()
        {
        }
    }
}