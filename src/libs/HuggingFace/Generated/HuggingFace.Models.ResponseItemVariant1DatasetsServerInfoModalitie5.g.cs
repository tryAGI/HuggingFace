
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoModalitie5
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
    public static class ResponseItemVariant1DatasetsServerInfoModalitie5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoModalitie5 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoModalitie5.x3d => "3d",
                ResponseItemVariant1DatasetsServerInfoModalitie5.Audio => "audio",
                ResponseItemVariant1DatasetsServerInfoModalitie5.Document => "document",
                ResponseItemVariant1DatasetsServerInfoModalitie5.Geospatial => "geospatial",
                ResponseItemVariant1DatasetsServerInfoModalitie5.Image => "image",
                ResponseItemVariant1DatasetsServerInfoModalitie5.Tabular => "tabular",
                ResponseItemVariant1DatasetsServerInfoModalitie5.Text => "text",
                ResponseItemVariant1DatasetsServerInfoModalitie5.Timeseries => "timeseries",
                ResponseItemVariant1DatasetsServerInfoModalitie5.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoModalitie5? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseItemVariant1DatasetsServerInfoModalitie5.x3d,
                "audio" => ResponseItemVariant1DatasetsServerInfoModalitie5.Audio,
                "document" => ResponseItemVariant1DatasetsServerInfoModalitie5.Document,
                "geospatial" => ResponseItemVariant1DatasetsServerInfoModalitie5.Geospatial,
                "image" => ResponseItemVariant1DatasetsServerInfoModalitie5.Image,
                "tabular" => ResponseItemVariant1DatasetsServerInfoModalitie5.Tabular,
                "text" => ResponseItemVariant1DatasetsServerInfoModalitie5.Text,
                "timeseries" => ResponseItemVariant1DatasetsServerInfoModalitie5.Timeseries,
                "video" => ResponseItemVariant1DatasetsServerInfoModalitie5.Video,
                _ => null,
            };
        }
    }
}