
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsCommitResponse
    {
        /// <summary>
        /// Whether the commit was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The URL of the pull request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullRequestUrl")]
        public string? PullRequestUrl { get; set; }

        /// <summary>
        /// The OID of the commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitOid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitOid { get; set; }

        /// <summary>
        /// The URL of the commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitUrl { get; set; }

        /// <summary>
        /// The output of the git hook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hookOutput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HookOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsCommitResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the commit was successful
        /// </param>
        /// <param name="pullRequestUrl">
        /// The URL of the pull request
        /// </param>
        /// <param name="commitOid">
        /// The OID of the commit
        /// </param>
        /// <param name="commitUrl">
        /// The URL of the commit
        /// </param>
        /// <param name="hookOutput">
        /// The output of the git hook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsCommitResponse(
            bool success,
            string commitOid,
            string commitUrl,
            string hookOutput,
            string? pullRequestUrl)
        {
            this.Success = success;
            this.CommitOid = commitOid ?? throw new global::System.ArgumentNullException(nameof(commitOid));
            this.CommitUrl = commitUrl ?? throw new global::System.ArgumentNullException(nameof(commitUrl));
            this.HookOutput = hookOutput ?? throw new global::System.ArgumentNullException(nameof(hookOutput));
            this.PullRequestUrl = pullRequestUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsCommitResponse" /> class.
        /// </summary>
        public CreateModelsCommitResponse()
        {
        }
    }
}