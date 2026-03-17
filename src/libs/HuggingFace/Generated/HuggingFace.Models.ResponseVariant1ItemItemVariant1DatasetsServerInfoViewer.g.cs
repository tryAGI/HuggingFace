
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer
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
    public static class ResponseVariant1ItemItemVariant1DatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.Preview => "preview",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.Preview,
                "viewer-partial" => ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.ViewerPartial,
                "viewer" => ResponseVariant1ItemItemVariant1DatasetsServerInfoViewer.Viewer,
                _ => null,
            };
        }
    }
}