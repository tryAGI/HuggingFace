
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response57
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.ResponseUsageItem2>> Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponsePeriod2 Period { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response57" /> class.
        /// </summary>
        /// <param name="usage"></param>
        /// <param name="period"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response57(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.ResponseUsageItem2>> usage,
            global::HuggingFace.ResponsePeriod2 period)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response57" /> class.
        /// </summary>
        public Response57()
        {
        }
    }
}