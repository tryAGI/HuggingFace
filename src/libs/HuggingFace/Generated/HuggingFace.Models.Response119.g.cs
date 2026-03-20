
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response119
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentlyTrending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.ResponseRecentlyTrendingItemVariant1, global::HuggingFace.ResponseRecentlyTrendingItemVariant2, global::HuggingFace.ResponseRecentlyTrendingItemVariant3>> RecentlyTrending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response119" /> class.
        /// </summary>
        /// <param name="recentlyTrending"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response119(
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.ResponseRecentlyTrendingItemVariant1, global::HuggingFace.ResponseRecentlyTrendingItemVariant2, global::HuggingFace.ResponseRecentlyTrendingItemVariant3>> recentlyTrending)
        {
            this.RecentlyTrending = recentlyTrending ?? throw new global::System.ArgumentNullException(nameof(recentlyTrending));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response119" /> class.
        /// </summary>
        public Response119()
        {
        }
    }
}