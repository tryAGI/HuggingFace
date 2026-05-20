
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPapersResponseLinkedModelAvailableInferenceProviderFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCalling")]
        public bool? ToolCalling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseLinkedModelAvailableInferenceProviderFeatures" /> class.
        /// </summary>
        /// <param name="toolCalling"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPapersResponseLinkedModelAvailableInferenceProviderFeatures(
            bool? toolCalling)
        {
            this.ToolCalling = toolCalling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseLinkedModelAvailableInferenceProviderFeatures" /> class.
        /// </summary>
        public GetPapersResponseLinkedModelAvailableInferenceProviderFeatures()
        {
        }

    }
}