
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsStorageResponse
    {
        /// <summary>
        /// Estimated storage in bytes that may be freed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedStorage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EstimatedStorage { get; set; }

        /// <summary>
        /// Whether the ref has already been deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refDeleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RefDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsStorageResponse" /> class.
        /// </summary>
        /// <param name="estimatedStorage">
        /// Estimated storage in bytes that may be freed
        /// </param>
        /// <param name="refDeleted">
        /// Whether the ref has already been deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsStorageResponse(
            double estimatedStorage,
            bool refDeleted)
        {
            this.EstimatedStorage = estimatedStorage;
            this.RefDeleted = refDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsStorageResponse" /> class.
        /// </summary>
        public GetDiscussionsStorageResponse()
        {
        }
    }
}