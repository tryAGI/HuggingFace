
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPapersResponseCommentAuthor
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
        [global::System.Text.Json.Serialization.JsonPropertyName("isBlockedByMe")]
        public bool? IsBlockedByMe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauthApp")]
        public global::HuggingFace.GetPapersResponseCommentAuthorOauthApp? OauthApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseCommentAuthor" /> class.
        /// </summary>
        /// <param name="isOwner"></param>
        /// <param name="isOrgMember"></param>
        /// <param name="isBlockedByMe"></param>
        /// <param name="oauthApp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPapersResponseCommentAuthor(
            bool? isOwner,
            bool? isOrgMember,
            bool? isBlockedByMe,
            global::HuggingFace.GetPapersResponseCommentAuthorOauthApp? oauthApp)
        {
            this.IsOwner = isOwner;
            this.IsOrgMember = isOrgMember;
            this.IsBlockedByMe = isBlockedByMe;
            this.OauthApp = oauthApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseCommentAuthor" /> class.
        /// </summary>
        public GetPapersResponseCommentAuthor()
        {
        }

    }
}