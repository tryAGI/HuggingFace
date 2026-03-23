
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpecUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentationUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="specUri"></param>
        /// <param name="documentationUri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme(
            string type,
            string name,
            string description,
            string specUri,
            string documentationUri)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.SpecUri = specUri ?? throw new global::System.ArgumentNullException(nameof(specUri));
            this.DocumentationUri = documentationUri ?? throw new global::System.ArgumentNullException(nameof(documentationUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme" /> class.
        /// </summary>
        public GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme()
        {
        }
    }
}