
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsScimV2UsersResponseMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsScimV2UsersResponseMetaResourceTypeJsonConverter))]
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseMetaResourceType ResourceType { get; set; }

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
        /// Initializes a new instance of the <see cref="GetOrganizationsScimV2UsersResponseMeta" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="resourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsScimV2UsersResponseMeta(
            string location,
            global::HuggingFace.GetOrganizationsScimV2UsersResponseMetaResourceType resourceType)
        {
            this.ResourceType = resourceType;
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsScimV2UsersResponseMeta" /> class.
        /// </summary>
        public GetOrganizationsScimV2UsersResponseMeta()
        {
        }
    }
}