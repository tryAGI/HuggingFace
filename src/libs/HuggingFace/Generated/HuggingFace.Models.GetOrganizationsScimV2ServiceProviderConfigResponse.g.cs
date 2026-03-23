
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsScimV2ServiceProviderConfigResponse
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
        public required global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponsePatch Patch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseBulk Bulk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseFilter Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changePassword")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseChangePassword ChangePassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseSort Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseEtag Etag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationSchemes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme> AuthenticationSchemes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsScimV2ServiceProviderConfigResponse" /> class.
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
        public GetOrganizationsScimV2ServiceProviderConfigResponse(
            global::System.Collections.Generic.IList<string> schemas,
            string documentationUri,
            global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponsePatch patch,
            global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseBulk bulk,
            global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseFilter filter,
            global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseChangePassword changePassword,
            global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseSort sort,
            global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseEtag etag,
            global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme> authenticationSchemes,
            global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseMeta meta)
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
        /// Initializes a new instance of the <see cref="GetOrganizationsScimV2ServiceProviderConfigResponse" /> class.
        /// </summary>
        public GetOrganizationsScimV2ServiceProviderConfigResponse()
        {
        }
    }
}