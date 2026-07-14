
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBucketsResponseDisabled
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideReadme")]
        public bool? HideReadme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBucketsResponseDisabled" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="hideReadme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBucketsResponseDisabled(
            string reason,
            bool? hideReadme)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.HideReadme = hideReadme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBucketsResponseDisabled" /> class.
        /// </summary>
        public GetBucketsResponseDisabled()
        {
        }

    }
}