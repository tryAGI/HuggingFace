
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant2EventVariant9Data
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hiddenCommits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HiddenCommits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headOid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadOid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2EventVariant9Data" /> class.
        /// </summary>
        /// <param name="hiddenCommits"></param>
        /// <param name="headOid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseVariant2EventVariant9Data(
            double hiddenCommits,
            string headOid)
        {
            this.HiddenCommits = hiddenCommits;
            this.HeadOid = headOid ?? throw new global::System.ArgumentNullException(nameof(headOid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2EventVariant9Data" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant2EventVariant9Data()
        {
        }

    }
}