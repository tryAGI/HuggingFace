
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseDiscussion> Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Number of closed discussions on the first page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numClosedDiscussions")]
        public double? NumClosedDiscussions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponse" /> class.
        /// </summary>
        /// <param name="discussions"></param>
        /// <param name="count"></param>
        /// <param name="start"></param>
        /// <param name="numClosedDiscussions">
        /// Number of closed discussions on the first page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponse(
            global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseDiscussion> discussions,
            double count,
            double start,
            double? numClosedDiscussions)
        {
            this.Discussions = discussions ?? throw new global::System.ArgumentNullException(nameof(discussions));
            this.Count = count;
            this.Start = start;
            this.NumClosedDiscussions = numClosedDiscussions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponse" /> class.
        /// </summary>
        public GetDiscussionsResponse()
        {
        }
    }
}