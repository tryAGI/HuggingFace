
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant1ItemItemVariant3RuntimeHardware
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        public global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeHardwareCurrent2? Current { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested")]
        public global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeHardwareRequested2? Requested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1ItemItemVariant3RuntimeHardware" /> class.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="requested"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant1ItemItemVariant3RuntimeHardware(
            global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeHardwareCurrent2? current,
            global::HuggingFace.ResponseVariant1ItemItemVariant3RuntimeHardwareRequested2? requested)
        {
            this.Current = current;
            this.Requested = requested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1ItemItemVariant3RuntimeHardware" /> class.
        /// </summary>
        public ResponseVariant1ItemItemVariant3RuntimeHardware()
        {
        }
    }
}