
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Entity the permissions apply to the organization itself, or one of its repositories
    /// </summary>
    public sealed partial class GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity(
            string id,
            global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity" /> class.
        /// </summary>
        public GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity()
        {
        }

    }
}