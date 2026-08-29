
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// OIDC client secret
    /// </summary>
    public sealed partial class PutOrganizationsSettingsSsoCredentialsRequestVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationsSettingsSsoCredentialsRequestVariant1" /> class.
        /// </summary>
        /// <param name="clientSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutOrganizationsSettingsSsoCredentialsRequestVariant1(
            string clientSecret)
        {
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationsSettingsSsoCredentialsRequestVariant1" /> class.
        /// </summary>
        public PutOrganizationsSettingsSsoCredentialsRequestVariant1()
        {
        }

    }
}