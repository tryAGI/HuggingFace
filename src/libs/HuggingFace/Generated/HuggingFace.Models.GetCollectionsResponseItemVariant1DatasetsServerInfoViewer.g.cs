
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant1DatasetsServerInfoViewer
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
    public static class GetCollectionsResponseItemVariant1DatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1DatasetsServerInfoViewer value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1DatasetsServerInfoViewer.Preview => "preview",
                GetCollectionsResponseItemVariant1DatasetsServerInfoViewer.Viewer => "viewer",
                GetCollectionsResponseItemVariant1DatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1DatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetCollectionsResponseItemVariant1DatasetsServerInfoViewer.Preview,
                "viewer" => GetCollectionsResponseItemVariant1DatasetsServerInfoViewer.Viewer,
                "viewer-partial" => GetCollectionsResponseItemVariant1DatasetsServerInfoViewer.ViewerPartial,
                _ => null,
            };
        }
    }
}