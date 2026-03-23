
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie
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
    public static class GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.x3d => "3d",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Audio => "audio",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Document => "document",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Geospatial => "geospatial",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Image => "image",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Tabular => "tabular",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Text => "text",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Timeseries => "timeseries",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.x3d,
                "audio" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Audio,
                "document" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Document,
                "geospatial" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Geospatial,
                "image" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Image,
                "tabular" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Tabular,
                "text" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Text,
                "timeseries" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Timeseries,
                "video" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}