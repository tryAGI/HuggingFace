
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsSocialsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialHandles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsSocialsResponseSocialHandles SocialHandles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSocialsResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="org"></param>
        /// <param name="socialHandles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsSocialsResponse(
            string id,
            string org,
            global::HuggingFace.GetOrganizationsSocialsResponseSocialHandles socialHandles)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.SocialHandles = socialHandles ?? throw new global::System.ArgumentNullException(nameof(socialHandles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSocialsResponse" /> class.
        /// </summary>
        public GetOrganizationsSocialsResponse()
        {
        }
    }
}