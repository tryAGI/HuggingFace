
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTrendingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentlyTrending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1, global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2, global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3>> RecentlyTrending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponse" /> class.
        /// </summary>
        /// <param name="recentlyTrending"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrendingResponse(
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1, global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2, global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3>> recentlyTrending)
        {
            this.RecentlyTrending = recentlyTrending ?? throw new global::System.ArgumentNullException(nameof(recentlyTrending));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponse" /> class.
        /// </summary>
        public GetTrendingResponse()
        {
        }
    }
}