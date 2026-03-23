
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie
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
    public static class CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.x3d => "3d",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Audio => "audio",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Document => "document",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Geospatial => "geospatial",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Image => "image",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Tabular => "tabular",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Text => "text",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Timeseries => "timeseries",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.x3d,
                "audio" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Audio,
                "document" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Document,
                "geospatial" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Geospatial,
                "image" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Image,
                "tabular" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Tabular,
                "text" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Text,
                "timeseries" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Timeseries,
                "video" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}