
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsResponseDataItemVariant3RuntimeHardware2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4? Current { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested")]
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareRequested4? Requested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant3RuntimeHardware2" /> class.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="requested"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsResponseDataItemVariant3RuntimeHardware2(
            global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4? current,
            global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareRequested4? requested)
        {
            this.Current = current;
            this.Requested = requested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant3RuntimeHardware2" /> class.
        /// </summary>
        public PatchCollectionsResponseDataItemVariant3RuntimeHardware2()
        {
        }
    }
}