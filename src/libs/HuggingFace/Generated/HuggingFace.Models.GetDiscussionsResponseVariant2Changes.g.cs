
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant2Changes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergeCommitId")]
        public string? MergeCommitId { get; set; }

        /// <summary>
        /// The last commit ID of the PR branch, stored before ref deletion so diffs can still be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headCommitId")]
        public string? HeadCommitId { get; set; }

        /// <summary>
        /// Whether the PR ref has been deleted (to free up storage).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refDeleted")]
        public bool? RefDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2Changes" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="mergeCommitId"></param>
        /// <param name="headCommitId">
        /// The last commit ID of the PR branch, stored before ref deletion so diffs can still be computed.
        /// </param>
        /// <param name="refDeleted">
        /// Whether the PR ref has been deleted (to free up storage).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseVariant2Changes(
            string @base,
            string? mergeCommitId,
            string? headCommitId,
            bool? refDeleted)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.MergeCommitId = mergeCommitId;
            this.HeadCommitId = headCommitId;
            this.RefDeleted = refDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2Changes" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant2Changes()
        {
        }
    }
}