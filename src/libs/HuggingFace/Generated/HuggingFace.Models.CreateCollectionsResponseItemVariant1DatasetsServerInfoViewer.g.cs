
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer
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
    public static class CreateCollectionsResponseItemVariant1DatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer.Preview => "preview",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer.Viewer => "viewer",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer.Preview,
                "viewer" => CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer.Viewer,
                "viewer-partial" => CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer.ViewerPartial,
                _ => null,
            };
        }
    }
}