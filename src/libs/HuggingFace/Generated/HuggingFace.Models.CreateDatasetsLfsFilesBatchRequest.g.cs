
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetsLfsFilesBatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDatasetsLfsFilesBatchRequestDeletions Deletions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsLfsFilesBatchRequest" /> class.
        /// </summary>
        /// <param name="deletions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetsLfsFilesBatchRequest(
            global::HuggingFace.CreateDatasetsLfsFilesBatchRequestDeletions deletions)
        {
            this.Deletions = deletions ?? throw new global::System.ArgumentNullException(nameof(deletions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetsLfsFilesBatchRequest" /> class.
        /// </summary>
        public CreateDatasetsLfsFilesBatchRequest()
        {
        }
    }
}