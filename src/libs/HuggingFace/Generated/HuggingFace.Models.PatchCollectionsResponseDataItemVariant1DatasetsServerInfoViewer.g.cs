
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
        /// <summary>
        /// 
        /// </summary>
        ViewerPartial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer.Preview => "preview",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer.Viewer => "viewer",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer.Preview,
                "viewer" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer.Viewer,
                "viewer-partial" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer.ViewerPartial,
                _ => null,
            };
        }
    }
}