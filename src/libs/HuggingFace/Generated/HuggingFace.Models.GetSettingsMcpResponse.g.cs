
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSettingsMcpResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtInTools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BuiltInTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceTools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsMcpResponseSpaceTool> SpaceTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsMcpResponse" /> class.
        /// </summary>
        /// <param name="builtInTools"></param>
        /// <param name="spaceTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSettingsMcpResponse(
            global::System.Collections.Generic.IList<string> builtInTools,
            global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsMcpResponseSpaceTool> spaceTools)
        {
            this.BuiltInTools = builtInTools ?? throw new global::System.ArgumentNullException(nameof(builtInTools));
            this.SpaceTools = spaceTools ?? throw new global::System.ArgumentNullException(nameof(spaceTools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsMcpResponse" /> class.
        /// </summary>
        public GetSettingsMcpResponse()
        {
        }
    }
}