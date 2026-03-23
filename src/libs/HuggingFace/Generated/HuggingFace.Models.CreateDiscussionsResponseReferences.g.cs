
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDiscussionsResponseReferences
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsResponseReferences" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="mergeCommitId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDiscussionsResponseReferences(
            string @base,
            string? mergeCommitId)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.MergeCommitId = mergeCommitId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsResponseReferences" /> class.
        /// </summary>
        public CreateDiscussionsResponseReferences()
        {
        }
    }
}