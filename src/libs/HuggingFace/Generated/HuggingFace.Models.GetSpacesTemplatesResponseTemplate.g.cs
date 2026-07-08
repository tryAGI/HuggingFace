
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpacesTemplatesResponseTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetSpacesTemplatesResponseTemplateSdkJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk Sdk { get; set; }

        /// <summary>
        /// Human-friendly name of the template (e.g. `JupyterLab`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Repo id of the template Space, to pass as `template` on create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoId { get; set; }

        /// <summary>
        /// Whether the created Space is expected to be private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferredPrivate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PreferredPrivate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesTemplatesResponseTemplate" /> class.
        /// </summary>
        /// <param name="sdk"></param>
        /// <param name="name">
        /// Human-friendly name of the template (e.g. `JupyterLab`).
        /// </param>
        /// <param name="repoId">
        /// Repo id of the template Space, to pass as `template` on create.
        /// </param>
        /// <param name="preferredPrivate">
        /// Whether the created Space is expected to be private.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpacesTemplatesResponseTemplate(
            global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk sdk,
            string name,
            string repoId,
            bool preferredPrivate)
        {
            this.Sdk = sdk;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RepoId = repoId ?? throw new global::System.ArgumentNullException(nameof(repoId));
            this.PreferredPrivate = preferredPrivate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesTemplatesResponseTemplate" /> class.
        /// </summary>
        public GetSpacesTemplatesResponseTemplate()
        {
        }

    }
}