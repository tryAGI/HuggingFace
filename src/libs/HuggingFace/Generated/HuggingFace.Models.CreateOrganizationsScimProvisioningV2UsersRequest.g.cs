
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationsScimProvisioningV2UsersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemas { get; set; }

        /// <summary>
        /// Username of the existing Hugging Face user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequestEmail> Emails { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// SSO unique identifier (SAML nameid or OIDC sub claim) - required for SSO login
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsScimProvisioningV2UsersRequest" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="userName">
        /// Username of the existing Hugging Face user
        /// </param>
        /// <param name="emails"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="externalId">
        /// SSO unique identifier (SAML nameid or OIDC sub claim) - required for SSO login
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsScimProvisioningV2UsersRequest(
            global::System.Collections.Generic.IList<string> schemas,
            string userName,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequestEmail> emails,
            string externalId,
            bool? active)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsScimProvisioningV2UsersRequest" /> class.
        /// </summary>
        public CreateOrganizationsScimProvisioningV2UsersRequest()
        {
        }
    }
}