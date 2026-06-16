
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentHarnessesResponse
    {
        /// <summary>
        /// Standard environment variables that any agent can set to identify itself. Their value is matched against the harness ids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standardEnvVars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> StandardEnvVars { get; set; }

        /// <summary>
        /// Registered harnesses, keyed by id and ordered by detection priority: the first match wins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harnesses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetAgentHarnessesResponseHarnesses2> Harnesses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentHarnessesResponse" /> class.
        /// </summary>
        /// <param name="standardEnvVars">
        /// Standard environment variables that any agent can set to identify itself. Their value is matched against the harness ids.
        /// </param>
        /// <param name="harnesses">
        /// Registered harnesses, keyed by id and ordered by detection priority: the first match wins
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentHarnessesResponse(
            global::System.Collections.Generic.IList<string> standardEnvVars,
            global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetAgentHarnessesResponseHarnesses2> harnesses)
        {
            this.StandardEnvVars = standardEnvVars ?? throw new global::System.ArgumentNullException(nameof(standardEnvVars));
            this.Harnesses = harnesses ?? throw new global::System.ArgumentNullException(nameof(harnesses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentHarnessesResponse" /> class.
        /// </summary>
        public GetAgentHarnessesResponse()
        {
        }

    }
}