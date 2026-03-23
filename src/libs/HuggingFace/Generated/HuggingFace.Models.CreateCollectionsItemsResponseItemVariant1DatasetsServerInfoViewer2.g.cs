
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2
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
    public static class CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2.Preview => "preview",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2.Viewer => "viewer",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2.Preview,
                "viewer" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2.Viewer,
                "viewer-partial" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2.ViewerPartial,
                _ => null,
            };
        }
    }
}