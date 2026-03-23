
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsScimV2ServiceProviderConfigResponsePatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsScimV2ServiceProviderConfigResponsePatch" /> class.
        /// </summary>
        /// <param name="supported"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsScimV2ServiceProviderConfigResponsePatch(
            bool supported)
        {
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsScimV2ServiceProviderConfigResponsePatch" /> class.
        /// </summary>
        public GetOrganizationsScimV2ServiceProviderConfigResponsePatch()
        {
        }
    }
}