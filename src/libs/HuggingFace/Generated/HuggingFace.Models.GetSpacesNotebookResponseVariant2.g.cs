
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpacesNotebookResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"True"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("notInCache")]
        public string NotInCache { get; set; } = "True";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesNotebookResponseVariant2" /> class.
        /// </summary>
        /// <param name="notInCache"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpacesNotebookResponseVariant2(
            string notInCache = "True")
        {
            this.NotInCache = notInCache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesNotebookResponseVariant2" /> class.
        /// </summary>
        public GetSpacesNotebookResponseVariant2()
        {
        }
    }
}