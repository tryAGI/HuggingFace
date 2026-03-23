
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDiscussionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::HuggingFace.CreateDiscussionsResponseReferences? References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsResponse" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="num"></param>
        /// <param name="pullRequest"></param>
        /// <param name="references"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDiscussionsResponse(
            string url,
            double num,
            bool pullRequest,
            global::HuggingFace.CreateDiscussionsResponseReferences? references)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Num = num;
            this.PullRequest = pullRequest;
            this.References = references;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsResponse" /> class.
        /// </summary>
        public CreateDiscussionsResponse()
        {
        }
    }
}