
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer
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
    public static class CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer.Preview => "preview",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer.Viewer => "viewer",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer.Preview,
                "viewer" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer.Viewer,
                "viewer-partial" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer.ViewerPartial,
                _ => null,
            };
        }
    }
}