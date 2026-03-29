
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCustom")]
        public bool? IsCustom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage Stage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="stage"></param>
        /// <param name="isCustom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain(
            string domain,
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage stage,
            bool? isCustom)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.IsCustom = isCustom;
            this.Stage = stage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain" /> class.
        /// </summary>
        public GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain()
        {
        }
    }
}