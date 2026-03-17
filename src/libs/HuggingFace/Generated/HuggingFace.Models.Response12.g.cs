
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentationUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponsePatch Patch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseBulk Bulk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseFilter Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changePassword")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseChangePassword ChangePassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseSort Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseEtag Etag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationSchemes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseAuthenticationScheme> AuthenticationSchemes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response12" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="documentationUri"></param>
        /// <param name="patch"></param>
        /// <param name="bulk"></param>
        /// <param name="filter"></param>
        /// <param name="changePassword"></param>
        /// <param name="sort"></param>
        /// <param name="etag"></param>
        /// <param name="authenticationSchemes"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response12(
            global::System.Collections.Generic.IList<string> schemas,
            string documentationUri,
            global::HuggingFace.ResponsePatch patch,
            global::HuggingFace.ResponseBulk bulk,
            global::HuggingFace.ResponseFilter filter,
            global::HuggingFace.ResponseChangePassword changePassword,
            global::HuggingFace.ResponseSort sort,
            global::HuggingFace.ResponseEtag etag,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseAuthenticationScheme> authenticationSchemes,
            global::HuggingFace.ResponseMeta meta)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.DocumentationUri = documentationUri ?? throw new global::System.ArgumentNullException(nameof(documentationUri));
            this.Patch = patch ?? throw new global::System.ArgumentNullException(nameof(patch));
            this.Bulk = bulk ?? throw new global::System.ArgumentNullException(nameof(bulk));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.ChangePassword = changePassword ?? throw new global::System.ArgumentNullException(nameof(changePassword));
            this.Sort = sort ?? throw new global::System.ArgumentNullException(nameof(sort));
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
            this.AuthenticationSchemes = authenticationSchemes ?? throw new global::System.ArgumentNullException(nameof(authenticationSchemes));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response12" /> class.
        /// </summary>
        public Response12()
        {
        }
    }
}