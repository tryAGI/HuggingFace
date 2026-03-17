
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseRecentlyTrendingItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"space"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoType")]
        public string RepoType { get; set; } = "space";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseRecentlyTrendingItemVariant3RepoData RepoData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRecentlyTrendingItemVariant3" /> class.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="repoData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseRecentlyTrendingItemVariant3(
            global::HuggingFace.ResponseRecentlyTrendingItemVariant3RepoData repoData,
            string repoType = "space")
        {
            this.RepoData = repoData ?? throw new global::System.ArgumentNullException(nameof(repoData));
            this.RepoType = repoType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRecentlyTrendingItemVariant3" /> class.
        /// </summary>
        public ResponseRecentlyTrendingItemVariant3()
        {
        }
    }
}