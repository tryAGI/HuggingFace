
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutOrganizationsScimProvisioningV2UsersResponseEmail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Primary { get; set; }

        /// <summary>
        /// We only support work emails, other types are converted to work
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PutOrganizationsScimProvisioningV2UsersResponseEmailTypeJsonConverter))]
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmailType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationsScimProvisioningV2UsersResponseEmail" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="primary"></param>
        /// <param name="type">
        /// We only support work emails, other types are converted to work
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutOrganizationsScimProvisioningV2UsersResponseEmail(
            string value,
            bool primary,
            global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmailType? type)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Primary = primary;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationsScimProvisioningV2UsersResponseEmail" /> class.
        /// </summary>
        public PutOrganizationsScimProvisioningV2UsersResponseEmail()
        {
        }
    }
}