
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareCurrent? Current { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested")]
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested? Requested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware" /> class.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="requested"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware(
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareCurrent? current,
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested? requested)
        {
            this.Current = current;
            this.Requested = requested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware" /> class.
        /// </summary>
        public GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware()
        {
        }

    }
}