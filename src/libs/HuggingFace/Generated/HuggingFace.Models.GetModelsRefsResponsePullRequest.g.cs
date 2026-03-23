
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelsRefsResponsePullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetCommit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetCommit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsRefsResponsePullRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ref"></param>
        /// <param name="targetCommit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsRefsResponsePullRequest(
            string name,
            string @ref,
            string targetCommit)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.TargetCommit = targetCommit ?? throw new global::System.ArgumentNullException(nameof(targetCommit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsRefsResponsePullRequest" /> class.
        /// </summary>
        public GetModelsRefsResponsePullRequest()
        {
        }
    }
}