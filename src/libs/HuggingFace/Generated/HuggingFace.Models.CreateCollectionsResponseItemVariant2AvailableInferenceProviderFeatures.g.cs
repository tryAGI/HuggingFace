
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsResponseItemVariant2AvailableInferenceProviderFeatures
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
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseItemVariant2AvailableInferenceProviderFeatures" /> class.
        /// </summary>
        /// <param name="toolCalling"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsResponseItemVariant2AvailableInferenceProviderFeatures(
            bool? toolCalling)
        {
            this.ToolCalling = toolCalling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseItemVariant2AvailableInferenceProviderFeatures" /> class.
        /// </summary>
        public CreateCollectionsResponseItemVariant2AvailableInferenceProviderFeatures()
        {
        }
    }
}