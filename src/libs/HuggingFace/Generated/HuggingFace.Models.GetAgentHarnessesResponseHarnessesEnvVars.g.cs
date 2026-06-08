
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Environment variable(s) identifying this harness, mapped to the value pattern they must match: "*" (set to any non-empty value), an exact value, or a "&lt;prefix&gt;*" fuzzy match. Detection matches if ANY entry matches.
    /// </summary>
    public sealed partial class GetAgentHarnessesResponseHarnessesEnvVars
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}