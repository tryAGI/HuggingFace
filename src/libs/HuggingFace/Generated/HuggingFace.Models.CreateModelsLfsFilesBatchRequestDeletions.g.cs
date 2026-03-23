
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsLfsFilesBatchRequestDeletions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Sha { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewriteHistory")]
        public bool? RewriteHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesBatchRequestDeletions" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="rewriteHistory">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsLfsFilesBatchRequestDeletions(
            global::System.Collections.Generic.IList<string> sha,
            bool? rewriteHistory)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.RewriteHistory = rewriteHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesBatchRequestDeletions" /> class.
        /// </summary>
        public CreateModelsLfsFilesBatchRequestDeletions()
        {
        }
    }
}