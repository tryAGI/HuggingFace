
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsLfsFilesBatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateModelsLfsFilesBatchRequestDeletions Deletions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesBatchRequest" /> class.
        /// </summary>
        /// <param name="deletions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsLfsFilesBatchRequest(
            global::HuggingFace.CreateModelsLfsFilesBatchRequestDeletions deletions)
        {
            this.Deletions = deletions ?? throw new global::System.ArgumentNullException(nameof(deletions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsLfsFilesBatchRequest" /> class.
        /// </summary>
        public CreateModelsLfsFilesBatchRequest()
        {
        }
    }
}