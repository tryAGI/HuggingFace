
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetModelsNotebookResponseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("notInCache")]
        public bool NotInCache { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsNotebookResponseVariant2" /> class.
        /// </summary>
        /// <param name="notInCache"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsNotebookResponseVariant2(
            bool notInCache = true)
        {
            this.NotInCache = notInCache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsNotebookResponseVariant2" /> class.
        /// </summary>
        public GetModelsNotebookResponseVariant2()
        {
        }

    }
}