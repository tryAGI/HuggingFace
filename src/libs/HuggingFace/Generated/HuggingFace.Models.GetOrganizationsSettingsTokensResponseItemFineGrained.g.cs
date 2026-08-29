
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Permissions carried by a `fineGrained` token, narrowed to those that bear on the organization. Absent on `read` and `write` tokens, whose access is not expressed as a permission list, and never covering the account-wide permissions the token may hold elsewhere
    /// </summary>
    public sealed partial class GetOrganizationsSettingsTokensResponseItemFineGrained
    {
        /// <summary>
        /// Permissions the token holds on individual entities, limited to the organization and the repositories it owns. Scopes pointing elsewhere are omitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem> Scoped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemFineGrained" /> class.
        /// </summary>
        /// <param name="scoped">
        /// Permissions the token holds on individual entities, limited to the organization and the repositories it owns. Scopes pointing elsewhere are omitted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSettingsTokensResponseItemFineGrained(
            global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem> scoped)
        {
            this.Scoped = scoped ?? throw new global::System.ArgumentNullException(nameof(scoped));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemFineGrained" /> class.
        /// </summary>
        public GetOrganizationsSettingsTokensResponseItemFineGrained()
        {
        }

    }
}