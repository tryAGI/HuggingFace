
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsScimProvisioningV2GroupsResponseResourceMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceTypeJsonConverter))]
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType ResourceType { get; set; }

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
        /// Initializes a new instance of the <see cref="GetOrganizationsScimProvisioningV2GroupsResponseResourceMeta" /> class.
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="location"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsScimProvisioningV2GroupsResponseResourceMeta(
            string location,
            global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType resourceType)
        {
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.ResourceType = resourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsScimProvisioningV2GroupsResponseResourceMeta" /> class.
        /// </summary>
        public GetOrganizationsScimProvisioningV2GroupsResponseResourceMeta()
        {
        }
    }
}