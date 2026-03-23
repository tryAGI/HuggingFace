
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSettingsPapersClaimRequest
    {
        /// <summary>
        /// ArXiv paper identifier being claimed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paperId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PaperId { get; set; }

        /// <summary>
        /// Author entry on the paper being claimed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimAuthorId")]
        public string? ClaimAuthorId { get; set; }

        /// <summary>
        /// HF user who should receive the claim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetUserId")]
        public string? TargetUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsPapersClaimRequest" /> class.
        /// </summary>
        /// <param name="paperId">
        /// ArXiv paper identifier being claimed.
        /// </param>
        /// <param name="claimAuthorId">
        /// Author entry on the paper being claimed.
        /// </param>
        /// <param name="targetUserId">
        /// HF user who should receive the claim.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsPapersClaimRequest(
            string paperId,
            string? claimAuthorId,
            string? targetUserId)
        {
            this.PaperId = paperId ?? throw new global::System.ArgumentNullException(nameof(paperId));
            this.ClaimAuthorId = claimAuthorId;
            this.TargetUserId = targetUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsPapersClaimRequest" /> class.
        /// </summary>
        public CreateSettingsPapersClaimRequest()
        {
        }
    }
}