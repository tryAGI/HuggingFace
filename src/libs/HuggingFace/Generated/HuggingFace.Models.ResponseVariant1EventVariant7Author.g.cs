
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant1EventVariant7Author
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isOwner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isOrgMember")]
        public bool? IsOrgMember { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauthApp")]
        public global::HuggingFace.ResponseVariant1EventVariant7AuthorOauthApp? OauthApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1EventVariant7Author" /> class.
        /// </summary>
        /// <param name="isOwner"></param>
        /// <param name="isOrgMember"></param>
        /// <param name="oauthApp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant1EventVariant7Author(
            bool? isOwner,
            bool? isOrgMember,
            global::HuggingFace.ResponseVariant1EventVariant7AuthorOauthApp? oauthApp)
        {
            this.IsOwner = isOwner;
            this.IsOrgMember = isOrgMember;
            this.OauthApp = oauthApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1EventVariant7Author" /> class.
        /// </summary>
        public ResponseVariant1EventVariant7Author()
        {
        }
    }
}