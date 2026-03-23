
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2
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
    public static class GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.x3d => "3d",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Audio => "audio",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Document => "document",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Geospatial => "geospatial",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Image => "image",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Tabular => "tabular",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Text => "text",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Timeseries => "timeseries",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2? ToEnum(string value)
        {
            return value switch
            {
                "3d" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.x3d,
                "audio" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Audio,
                "document" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Document,
                "geospatial" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Geospatial,
                "image" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Image,
                "tabular" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Tabular,
                "text" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Text,
                "timeseries" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Timeseries,
                "video" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2.Video,
                _ => null,
            };
        }
    }
}