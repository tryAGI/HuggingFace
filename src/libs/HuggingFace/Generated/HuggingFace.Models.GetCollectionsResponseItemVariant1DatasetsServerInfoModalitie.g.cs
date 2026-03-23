
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie
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
    public static class GetCollectionsResponseItemVariant1DatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.x3d => "3d",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Audio => "audio",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Document => "document",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Geospatial => "geospatial",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Image => "image",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Tabular => "tabular",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Text => "text",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Timeseries => "timeseries",
                GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.x3d,
                "audio" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Audio,
                "document" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Document,
                "geospatial" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Geospatial,
                "image" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Image,
                "tabular" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Tabular,
                "text" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Text,
                "timeseries" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Timeseries,
                "video" => GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}