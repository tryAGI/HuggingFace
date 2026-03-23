
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchSettingsWatchRequest
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestDeleteItem>? Delete { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add")]
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestAddItem>? Add { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSettingsWatchRequest" /> class.
        /// </summary>
        /// <param name="delete">
        /// Default Value: []
        /// </param>
        /// <param name="add">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchSettingsWatchRequest(
            global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestDeleteItem>? delete,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestAddItem>? add)
        {
            this.Delete = delete;
            this.Add = add;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSettingsWatchRequest" /> class.
        /// </summary>
        public PatchSettingsWatchRequest()
        {
        }
    }
}