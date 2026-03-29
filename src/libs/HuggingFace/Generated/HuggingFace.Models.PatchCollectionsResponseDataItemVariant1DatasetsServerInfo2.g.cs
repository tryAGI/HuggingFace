
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer2 Viewer { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2> Libraries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2> Formats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2> Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2" /> class.
        /// </summary>
        /// <param name="viewer"></param>
        /// <param name="libraries"></param>
        /// <param name="formats"></param>
        /// <param name="modalities"></param>
        /// <param name="numRows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2(
            global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer2 viewer,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2> libraries,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2> formats,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2> modalities,
            double? numRows)
        {
            this.Viewer = viewer;
            this.NumRows = numRows;
            this.Libraries = libraries ?? throw new global::System.ArgumentNullException(nameof(libraries));
            this.Formats = formats ?? throw new global::System.ArgumentNullException(nameof(formats));
            this.Modalities = modalities ?? throw new global::System.ArgumentNullException(nameof(modalities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2" /> class.
        /// </summary>
        public PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2()
        {
        }
    }
}