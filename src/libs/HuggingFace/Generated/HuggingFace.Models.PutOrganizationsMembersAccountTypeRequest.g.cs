
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutOrganizationsMembersAccountTypeRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PutOrganizationsMembersAccountTypeRequestAccountTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PutOrganizationsMembersAccountTypeRequestAccountType AccountType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationsMembersAccountTypeRequest" /> class.
        /// </summary>
        /// <param name="accountType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutOrganizationsMembersAccountTypeRequest(
            global::HuggingFace.PutOrganizationsMembersAccountTypeRequestAccountType accountType)
        {
            this.AccountType = accountType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationsMembersAccountTypeRequest" /> class.
        /// </summary>
        public PutOrganizationsMembersAccountTypeRequest()
        {
        }

    }
}