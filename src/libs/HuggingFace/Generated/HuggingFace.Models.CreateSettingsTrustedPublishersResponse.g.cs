
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSettingsTrustedPublishersResponse
    {
        /// <summary>
        /// A hex string of 24 characters representing an ObjectId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuerUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Claims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.CreateSettingsTrustedPublishersResponseConfiguredByVariant1, global::HuggingFace.CreateSettingsTrustedPublishersResponseConfiguredByVariant2>))]
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsTrustedPublishersResponseConfiguredByVariant1, global::HuggingFace.CreateSettingsTrustedPublishersResponseConfiguredByVariant2>? ConfiguredBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsTrustedPublishersResponseCapabilitie>? Capabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsTrustedPublishersResponsePermission>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsTrustedPublishersResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A hex string of 24 characters representing an ObjectId.
        /// </param>
        /// <param name="issuerUrl"></param>
        /// <param name="claims"></param>
        /// <param name="createdAt"></param>
        /// <param name="configuredBy"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="capabilities"></param>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsTrustedPublishersResponse(
            string id,
            string issuerUrl,
            object claims,
            global::System.DateTime createdAt,
            global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsTrustedPublishersResponseConfiguredByVariant1, global::HuggingFace.CreateSettingsTrustedPublishersResponseConfiguredByVariant2>? configuredBy,
            global::System.DateTime? lastUsedAt,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsTrustedPublishersResponseCapabilitie>? capabilities,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsTrustedPublishersResponsePermission>? permissions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
            this.ConfiguredBy = configuredBy;
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
            this.Capabilities = capabilities;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsTrustedPublishersResponse" /> class.
        /// </summary>
        public CreateSettingsTrustedPublishersResponse()
        {
        }

    }
}