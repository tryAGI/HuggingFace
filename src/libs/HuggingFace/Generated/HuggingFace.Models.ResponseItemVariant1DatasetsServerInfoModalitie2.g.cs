
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoModalitie2
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
    public static class ResponseItemVariant1DatasetsServerInfoModalitie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoModalitie2 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoModalitie2.x3d => "3d",
                ResponseItemVariant1DatasetsServerInfoModalitie2.Audio => "audio",
                ResponseItemVariant1DatasetsServerInfoModalitie2.Document => "document",
                ResponseItemVariant1DatasetsServerInfoModalitie2.Geospatial => "geospatial",
                ResponseItemVariant1DatasetsServerInfoModalitie2.Image => "image",
                ResponseItemVariant1DatasetsServerInfoModalitie2.Tabular => "tabular",
                ResponseItemVariant1DatasetsServerInfoModalitie2.Text => "text",
                ResponseItemVariant1DatasetsServerInfoModalitie2.Timeseries => "timeseries",
                ResponseItemVariant1DatasetsServerInfoModalitie2.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoModalitie2? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseItemVariant1DatasetsServerInfoModalitie2.x3d,
                "audio" => ResponseItemVariant1DatasetsServerInfoModalitie2.Audio,
                "document" => ResponseItemVariant1DatasetsServerInfoModalitie2.Document,
                "geospatial" => ResponseItemVariant1DatasetsServerInfoModalitie2.Geospatial,
                "image" => ResponseItemVariant1DatasetsServerInfoModalitie2.Image,
                "tabular" => ResponseItemVariant1DatasetsServerInfoModalitie2.Tabular,
                "text" => ResponseItemVariant1DatasetsServerInfoModalitie2.Text,
                "timeseries" => ResponseItemVariant1DatasetsServerInfoModalitie2.Timeseries,
                "video" => ResponseItemVariant1DatasetsServerInfoModalitie2.Video,
                _ => null,
            };
        }
    }
}