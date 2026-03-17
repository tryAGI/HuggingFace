
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemVariant1DatasetsServerInfo3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant1DatasetsServerInfoViewer3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVariant1DatasetsServerInfoViewer3 Viewer { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemVariant1DatasetsServerInfoLibrarie3> Libraries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemVariant1DatasetsServerInfoFormat3> Formats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemVariant1DatasetsServerInfoModalitie3> Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant1DatasetsServerInfo3" /> class.
        /// </summary>
        /// <param name="viewer"></param>
        /// <param name="numRows"></param>
        /// <param name="libraries"></param>
        /// <param name="formats"></param>
        /// <param name="modalities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemVariant1DatasetsServerInfo3(
            global::HuggingFace.ResponseItemVariant1DatasetsServerInfoViewer3 viewer,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemVariant1DatasetsServerInfoLibrarie3> libraries,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemVariant1DatasetsServerInfoFormat3> formats,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseItemVariant1DatasetsServerInfoModalitie3> modalities,
            double? numRows)
        {
            this.Viewer = viewer;
            this.Libraries = libraries ?? throw new global::System.ArgumentNullException(nameof(libraries));
            this.Formats = formats ?? throw new global::System.ArgumentNullException(nameof(formats));
            this.Modalities = modalities ?? throw new global::System.ArgumentNullException(nameof(modalities));
            this.NumRows = numRows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant1DatasetsServerInfo3" /> class.
        /// </summary>
        public ResponseItemVariant1DatasetsServerInfo3()
        {
        }
    }
}