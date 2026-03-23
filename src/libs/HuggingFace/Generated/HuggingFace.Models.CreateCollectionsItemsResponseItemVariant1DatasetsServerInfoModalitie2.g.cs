
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2
    {
        /// <summary>
        /// 
        /// </summary>
        x3d,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Geospatial,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Tabular,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Timeseries,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.x3d => "3d",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Audio => "audio",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Document => "document",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Geospatial => "geospatial",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Image => "image",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Tabular => "tabular",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Text => "text",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Timeseries => "timeseries",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2? ToEnum(string value)
        {
            return value switch
            {
                "3d" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.x3d,
                "audio" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Audio,
                "document" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Document,
                "geospatial" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Geospatial,
                "image" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Image,
                "tabular" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Tabular,
                "text" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Text,
                "timeseries" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Timeseries,
                "video" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2.Video,
                _ => null,
            };
        }
    }
}