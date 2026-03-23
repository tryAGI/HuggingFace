
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2
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
    public static class GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2.Preview => "preview",
                GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2.Viewer => "viewer",
                GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2.Preview,
                "viewer" => GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2.Viewer,
                "viewer-partial" => GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2.ViewerPartial,
                _ => null,
            };
        }
    }
}