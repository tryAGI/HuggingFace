
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsSettingsRepositoriesResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesResponseItemVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storagePercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StoragePercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsRepositoriesResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="updatedAt"></param>
        /// <param name="visibility"></param>
        /// <param name="storage"></param>
        /// <param name="storagePercent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSettingsRepositoriesResponseItem(
            string id,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType type,
            string updatedAt,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility visibility,
            double storage,
            double storagePercent)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Visibility = visibility;
            this.Storage = storage;
            this.StoragePercent = storagePercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsRepositoriesResponseItem" /> class.
        /// </summary>
        public GetOrganizationsSettingsRepositoriesResponseItem()
        {
        }

    }
}