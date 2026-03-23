
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer
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
    public static class GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.Preview => "preview",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.Viewer => "viewer",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.Preview,
                "viewer" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.Viewer,
                "viewer-partial" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.ViewerPartial,
                _ => null,
            };
        }
    }
}