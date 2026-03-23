
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTrendingResponseRecentlyTrendingItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"model"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoType")]
        public string RepoType { get; set; } = "model";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoData RepoData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant2" /> class.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="repoData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrendingResponseRecentlyTrendingItemVariant2(
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoData repoData,
            string repoType = "model")
        {
            this.RepoData = repoData ?? throw new global::System.ArgumentNullException(nameof(repoData));
            this.RepoType = repoType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant2" /> class.
        /// </summary>
        public GetTrendingResponseRecentlyTrendingItemVariant2()
        {
        }
    }
}