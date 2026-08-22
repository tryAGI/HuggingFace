
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// SAML IdP x509 certificate
    /// </summary>
    public sealed partial class PutOrganizationsSettingsSsoCredentialsRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x509Cert")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string X509Cert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationsSettingsSsoCredentialsRequestVariant2" /> class.
        /// </summary>
        /// <param name="x509Cert"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutOrganizationsSettingsSsoCredentialsRequestVariant2(
            string x509Cert)
        {
            this.X509Cert = x509Cert ?? throw new global::System.ArgumentNullException(nameof(x509Cert));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationsSettingsSsoCredentialsRequestVariant2" /> class.
        /// </summary>
        public PutOrganizationsSettingsSsoCredentialsRequestVariant2()
        {
        }

    }
}