
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsSettingsNetworkSecurityResponseBlockedContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum?, string> Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsNetworkSecurityResponseBlockedContent" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSettingsNetworkSecurityResponseBlockedContent(
            global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum?, string> resource,
            string scope)
        {
            this.Resource = resource;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsNetworkSecurityResponseBlockedContent" /> class.
        /// </summary>
        public GetOrganizationsSettingsNetworkSecurityResponseBlockedContent()
        {
        }
    }
}