
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"scheduled-job"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "scheduled-job";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedBy")]
        public string? AddedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="addedBy"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5(
            string id,
            string? name,
            string? addedBy,
            string type = "scheduled-job")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.AddedBy = addedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5" /> class.
        /// </summary>
        public CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5 FromId(string id)
        {
            return new CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5
            {
                Id = id,
            };
        }

    }
}