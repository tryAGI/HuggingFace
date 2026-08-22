
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Where the token stands in the organization's approval flow. Reported by organizations that require administrator approval of member tokens, and on any token whose access has been revoked
    /// </summary>
    public sealed partial class GetOrganizationsSettingsTokensResponseItemAuthorization
    {
        /// <summary>
        /// `pending` while the token awaits an administrator's decision, `approved` once it may act on the organization, `denied` if an administrator refused it, and `revoked` if an administrator withdrew access it had already been granted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemAuthorizationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus Status { get; set; }

        /// <summary>
        /// Date the token first requested access to the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestedAt { get; set; }

        /// <summary>
        /// Date the token was granted access, recorded when the organization grants it automatically because the owner already holds write access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizedAt")]
        public global::System.DateTime? AuthorizedAt { get; set; }

        /// <summary>
        /// User who granted the token its access. Absent when `authorizedAt` is, and when that account has since been deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizer")]
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationAuthorizer? Authorizer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemAuthorization" /> class.
        /// </summary>
        /// <param name="status">
        /// `pending` while the token awaits an administrator's decision, `approved` once it may act on the organization, `denied` if an administrator refused it, and `revoked` if an administrator withdrew access it had already been granted
        /// </param>
        /// <param name="requestedAt">
        /// Date the token first requested access to the organization
        /// </param>
        /// <param name="authorizedAt">
        /// Date the token was granted access, recorded when the organization grants it automatically because the owner already holds write access
        /// </param>
        /// <param name="authorizer">
        /// User who granted the token its access. Absent when `authorizedAt` is, and when that account has since been deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSettingsTokensResponseItemAuthorization(
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus status,
            global::System.DateTime requestedAt,
            global::System.DateTime? authorizedAt,
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationAuthorizer? authorizer)
        {
            this.Status = status;
            this.RequestedAt = requestedAt;
            this.AuthorizedAt = authorizedAt;
            this.Authorizer = authorizer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemAuthorization" /> class.
        /// </summary>
        public GetOrganizationsSettingsTokensResponseItemAuthorization()
        {
        }

    }
}