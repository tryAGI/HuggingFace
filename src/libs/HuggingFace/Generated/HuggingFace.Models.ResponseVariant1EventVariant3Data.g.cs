
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant1EventVariant3Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Oid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1EventVariant3Data" /> class.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="oid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant1EventVariant3Data(
            string subject,
            string oid)
        {
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1EventVariant3Data" /> class.
        /// </summary>
        public ResponseVariant1EventVariant3Data()
        {
        }
    }
}