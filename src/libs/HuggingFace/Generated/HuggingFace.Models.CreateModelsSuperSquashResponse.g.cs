
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsSuperSquashResponse
    {
        /// <summary>
        /// The new commit ID after the squash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsSuperSquashResponse" /> class.
        /// </summary>
        /// <param name="commitId">
        /// The new commit ID after the squash
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsSuperSquashResponse(
            string commitId)
        {
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsSuperSquashResponse" /> class.
        /// </summary>
        public CreateModelsSuperSquashResponse()
        {
        }
    }
}