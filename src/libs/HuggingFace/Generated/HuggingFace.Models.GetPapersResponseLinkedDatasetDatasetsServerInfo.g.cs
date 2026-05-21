
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPapersResponseLinkedDatasetDatasetsServerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoViewerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer Viewer { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie> Libraries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat> Formats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie> Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseLinkedDatasetDatasetsServerInfo" /> class.
        /// </summary>
        /// <param name="viewer"></param>
        /// <param name="libraries"></param>
        /// <param name="formats"></param>
        /// <param name="modalities"></param>
        /// <param name="numRows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPapersResponseLinkedDatasetDatasetsServerInfo(
            global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer viewer,
            global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie> libraries,
            global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat> formats,
            global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie> modalities,
            double? numRows)
        {
            this.Viewer = viewer;
            this.NumRows = numRows;
            this.Libraries = libraries ?? throw new global::System.ArgumentNullException(nameof(libraries));
            this.Formats = formats ?? throw new global::System.ArgumentNullException(nameof(formats));
            this.Modalities = modalities ?? throw new global::System.ArgumentNullException(nameof(modalities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPapersResponseLinkedDatasetDatasetsServerInfo" /> class.
        /// </summary>
        public GetPapersResponseLinkedDatasetDatasetsServerInfo()
        {
        }

    }
}