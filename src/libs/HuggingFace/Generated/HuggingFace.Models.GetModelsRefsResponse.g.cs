
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelsRefsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseTag> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseBranche> Branches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("converts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseConvert> Converts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullRequests")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponsePullRequest>? PullRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsRefsResponse" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="branches"></param>
        /// <param name="converts"></param>
        /// <param name="pullRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsRefsResponse(
            global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseTag> tags,
            global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseBranche> branches,
            global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseConvert> converts,
            global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponsePullRequest>? pullRequests)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Branches = branches ?? throw new global::System.ArgumentNullException(nameof(branches));
            this.Converts = converts ?? throw new global::System.ArgumentNullException(nameof(converts));
            this.PullRequests = pullRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsRefsResponse" /> class.
        /// </summary>
        public GetModelsRefsResponse()
        {
        }
    }
}