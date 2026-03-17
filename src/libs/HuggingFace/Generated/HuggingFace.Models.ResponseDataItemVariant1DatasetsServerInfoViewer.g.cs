
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1DatasetsServerInfoViewer
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
    public static class ResponseDataItemVariant1DatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1DatasetsServerInfoViewer value)
        {
            return value switch
            {
                ResponseDataItemVariant1DatasetsServerInfoViewer.Preview => "preview",
                ResponseDataItemVariant1DatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                ResponseDataItemVariant1DatasetsServerInfoViewer.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1DatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => ResponseDataItemVariant1DatasetsServerInfoViewer.Preview,
                "viewer-partial" => ResponseDataItemVariant1DatasetsServerInfoViewer.ViewerPartial,
                "viewer" => ResponseDataItemVariant1DatasetsServerInfoViewer.Viewer,
                _ => null,
            };
        }
    }
}