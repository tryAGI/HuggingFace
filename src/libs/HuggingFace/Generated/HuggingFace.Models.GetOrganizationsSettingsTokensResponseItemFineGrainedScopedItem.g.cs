
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem
    {
        /// <summary>
        /// Entity the permissions apply to the organization itself, or one of its repositories
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity Entity { get; set; }

        /// <summary>
        /// Permissions the token holds on the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission> Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem" /> class.
        /// </summary>
        /// <param name="entity">
        /// Entity the permissions apply to the organization itself, or one of its repositories
        /// </param>
        /// <param name="permissions">
        /// Permissions the token holds on the entity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem(
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity entity,
            global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission> permissions)
        {
            this.Entity = entity ?? throw new global::System.ArgumentNullException(nameof(entity));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem" /> class.
        /// </summary>
        public GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem()
        {
        }

    }
}