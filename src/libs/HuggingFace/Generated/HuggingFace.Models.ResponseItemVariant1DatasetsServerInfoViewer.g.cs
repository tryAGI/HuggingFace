
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoViewer
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        ViewerPartial,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemVariant1DatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoViewer value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoViewer.Preview => "preview",
                ResponseItemVariant1DatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                ResponseItemVariant1DatasetsServerInfoViewer.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => ResponseItemVariant1DatasetsServerInfoViewer.Preview,
                "viewer-partial" => ResponseItemVariant1DatasetsServerInfoViewer.ViewerPartial,
                "viewer" => ResponseItemVariant1DatasetsServerInfoViewer.Viewer,
                _ => null,
            };
        }
    }
}