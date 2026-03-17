
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant1ItemItemVariant1DatasetsServerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseVariant1ItemItemVariant1DatasetsServerInfoViewerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer Viewer { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie> Libraries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat> Formats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie> Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1ItemItemVariant1DatasetsServerInfo" /> class.
        /// </summary>
        /// <param name="viewer"></param>
        /// <param name="numRows"></param>
        /// <param name="libraries"></param>
        /// <param name="formats"></param>
        /// <param name="modalities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant1ItemItemVariant1DatasetsServerInfo(
            global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer viewer,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie> libraries,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat> formats,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie> modalities,
            double? numRows)
        {
            this.Viewer = viewer;
            this.Libraries = libraries ?? throw new global::System.ArgumentNullException(nameof(libraries));
            this.Formats = formats ?? throw new global::System.ArgumentNullException(nameof(formats));
            this.Modalities = modalities ?? throw new global::System.ArgumentNullException(nameof(modalities));
            this.NumRows = numRows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant1ItemItemVariant1DatasetsServerInfo" /> class.
        /// </summary>
        public ResponseVariant1ItemItemVariant1DatasetsServerInfo()
        {
        }
    }
}