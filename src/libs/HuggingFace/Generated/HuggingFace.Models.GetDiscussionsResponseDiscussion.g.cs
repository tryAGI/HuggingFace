
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsResponseDiscussion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1, global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1, global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2>? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.RepoId Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topReactions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseDiscussionTopReaction> TopReactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDiscussionsResponseDiscussionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDiscussionsResponseDiscussionStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPullRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numComments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numReactionUsers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumReactionUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pinned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoOwner")]
        public global::HuggingFace.GetDiscussionsResponseDiscussionRepoOwner? RepoOwner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseDiscussion" /> class.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="repo"></param>
        /// <param name="title"></param>
        /// <param name="createdAt"></param>
        /// <param name="topReactions"></param>
        /// <param name="status"></param>
        /// <param name="isPullRequest"></param>
        /// <param name="numComments"></param>
        /// <param name="numReactionUsers"></param>
        /// <param name="pinned"></param>
        /// <param name="author"></param>
        /// <param name="repoOwner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseDiscussion(
            double num,
            global::HuggingFace.RepoId repo,
            string title,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseDiscussionTopReaction> topReactions,
            global::HuggingFace.GetDiscussionsResponseDiscussionStatus status,
            bool isPullRequest,
            double numComments,
            double numReactionUsers,
            bool pinned,
            global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1, global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2>? author,
            global::HuggingFace.GetDiscussionsResponseDiscussionRepoOwner? repoOwner)
        {
            this.Num = num;
            this.Author = author;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.CreatedAt = createdAt;
            this.TopReactions = topReactions ?? throw new global::System.ArgumentNullException(nameof(topReactions));
            this.Status = status;
            this.IsPullRequest = isPullRequest;
            this.NumComments = numComments;
            this.NumReactionUsers = numReactionUsers;
            this.Pinned = pinned;
            this.RepoOwner = repoOwner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseDiscussion" /> class.
        /// </summary>
        public GetDiscussionsResponseDiscussion()
        {
        }
    }
}