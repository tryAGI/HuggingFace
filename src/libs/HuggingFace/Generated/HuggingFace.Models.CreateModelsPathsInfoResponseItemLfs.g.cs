
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelsPathsInfoResponseItemLfs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointerSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PointerSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsPathsInfoResponseItemLfs" /> class.
        /// </summary>
        /// <param name="pointerSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelsPathsInfoResponseItemLfs(
            double pointerSize)
        {
            this.PointerSize = pointerSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelsPathsInfoResponseItemLfs" /> class.
        /// </summary>
        public CreateModelsPathsInfoResponseItemLfs()
        {
        }
    }
}