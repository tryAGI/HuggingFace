
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1DatasetsServerInfoViewer2
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
    public static class ResponseDataItemVariant1DatasetsServerInfoViewer2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1DatasetsServerInfoViewer2 value)
        {
            return value switch
            {
                ResponseDataItemVariant1DatasetsServerInfoViewer2.Preview => "preview",
                ResponseDataItemVariant1DatasetsServerInfoViewer2.ViewerPartial => "viewer-partial",
                ResponseDataItemVariant1DatasetsServerInfoViewer2.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1DatasetsServerInfoViewer2? ToEnum(string value)
        {
            return value switch
            {
                "preview" => ResponseDataItemVariant1DatasetsServerInfoViewer2.Preview,
                "viewer-partial" => ResponseDataItemVariant1DatasetsServerInfoViewer2.ViewerPartial,
                "viewer" => ResponseDataItemVariant1DatasetsServerInfoViewer2.Viewer,
                _ => null,
            };
        }
    }
}