
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request79
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectPage")]
        public string? ProjectPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubRepo")]
        public string? GithubRepo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request79" /> class.
        /// </summary>
        /// <param name="projectPage"></param>
        /// <param name="githubRepo"></param>
        /// <param name="organizationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request79(
            string? projectPage,
            string? githubRepo,
            string? organizationId)
        {
            this.ProjectPage = projectPage;
            this.GithubRepo = githubRepo;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request79" /> class.
        /// </summary>
        public Request79()
        {
        }
    }
}