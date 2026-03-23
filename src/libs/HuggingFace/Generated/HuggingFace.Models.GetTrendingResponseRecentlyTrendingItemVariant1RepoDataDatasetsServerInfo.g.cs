
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer Viewer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numRows")]
        public double? NumRows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("libraries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie> Libraries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat> Formats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie> Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfo" /> class.
        /// </summary>
        /// <param name="viewer"></param>
        /// <param name="numRows"></param>
        /// <param name="libraries"></param>
        /// <param name="formats"></param>
        /// <param name="modalities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfo(
            global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer viewer,
            global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie> libraries,
            global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat> formats,
            global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie> modalities,
            double? numRows)
        {
            this.Viewer = viewer;
            this.Libraries = libraries ?? throw new global::System.ArgumentNullException(nameof(libraries));
            this.Formats = formats ?? throw new global::System.ArgumentNullException(nameof(formats));
            this.Modalities = modalities ?? throw new global::System.ArgumentNullException(nameof(modalities));
            this.NumRows = numRows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfo" /> class.
        /// </summary>
        public GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfo()
        {
        }
    }
}