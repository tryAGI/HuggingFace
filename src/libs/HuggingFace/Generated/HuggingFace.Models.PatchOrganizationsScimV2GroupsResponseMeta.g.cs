
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsScimV2GroupsResponseMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchOrganizationsScimV2GroupsResponseMetaResourceTypeJsonConverter))]
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMetaResourceType ResourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimV2GroupsResponseMeta" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="resourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsScimV2GroupsResponseMeta(
            string location,
            global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMetaResourceType resourceType)
        {
            this.ResourceType = resourceType;
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimV2GroupsResponseMeta" /> class.
        /// </summary>
        public PatchOrganizationsScimV2GroupsResponseMeta()
        {
        }
    }
}