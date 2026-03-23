
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWhoamiV2ResponseAuthAccessTokenFineGrained
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem> Scoped { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>? Global { get; set; }

        /// <summary>
        /// Allow access to all public gated repos to which the user has access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canReadGatedRepos")]
        public bool? CanReadGatedRepos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhoamiV2ResponseAuthAccessTokenFineGrained" /> class.
        /// </summary>
        /// <param name="scoped"></param>
        /// <param name="global"></param>
        /// <param name="canReadGatedRepos">
        /// Allow access to all public gated repos to which the user has access
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWhoamiV2ResponseAuthAccessTokenFineGrained(
            global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem> scoped,
            global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>? global,
            bool? canReadGatedRepos)
        {
            this.Scoped = scoped ?? throw new global::System.ArgumentNullException(nameof(scoped));
            this.Global = global;
            this.CanReadGatedRepos = canReadGatedRepos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhoamiV2ResponseAuthAccessTokenFineGrained" /> class.
        /// </summary>
        public GetWhoamiV2ResponseAuthAccessTokenFineGrained()
        {
        }
    }
}