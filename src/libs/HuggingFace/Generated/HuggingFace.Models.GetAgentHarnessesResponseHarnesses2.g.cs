
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentHarnessesResponseHarnesses2
    {
        /// <summary>
        /// Human-readable name of the harness
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prettyLabel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrettyLabel { get; set; }

        /// <summary>
        /// URL to the harness's code repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUrl")]
        public string? RepoUrl { get; set; }

        /// <summary>
        /// URL to the harness's documentation or website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docsUrl")]
        public string? DocsUrl { get; set; }

        /// <summary>
        /// Short description of the harness
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Environment variable(s) identifying this harness, mapped to the value pattern they must match: "*" (set to any non-empty value), an exact value, or a "&lt;prefix&gt;*" fuzzy match. Detection matches if ANY entry matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVars")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvVars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentHarnessesResponseHarnesses2" /> class.
        /// </summary>
        /// <param name="prettyLabel">
        /// Human-readable name of the harness
        /// </param>
        /// <param name="repoUrl">
        /// URL to the harness's code repository
        /// </param>
        /// <param name="docsUrl">
        /// URL to the harness's documentation or website
        /// </param>
        /// <param name="description">
        /// Short description of the harness
        /// </param>
        /// <param name="envVars">
        /// Environment variable(s) identifying this harness, mapped to the value pattern they must match: "*" (set to any non-empty value), an exact value, or a "&lt;prefix&gt;*" fuzzy match. Detection matches if ANY entry matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentHarnessesResponseHarnesses2(
            string prettyLabel,
            string? repoUrl,
            string? docsUrl,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? envVars)
        {
            this.PrettyLabel = prettyLabel ?? throw new global::System.ArgumentNullException(nameof(prettyLabel));
            this.RepoUrl = repoUrl;
            this.DocsUrl = docsUrl;
            this.Description = description;
            this.EnvVars = envVars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentHarnessesResponseHarnesses2" /> class.
        /// </summary>
        public GetAgentHarnessesResponseHarnesses2()
        {
        }

    }
}