
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoModalitie4
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
    public static class ResponseItemVariant1DatasetsServerInfoModalitie4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoModalitie4 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoModalitie4.x3d => "3d",
                ResponseItemVariant1DatasetsServerInfoModalitie4.Audio => "audio",
                ResponseItemVariant1DatasetsServerInfoModalitie4.Document => "document",
                ResponseItemVariant1DatasetsServerInfoModalitie4.Geospatial => "geospatial",
                ResponseItemVariant1DatasetsServerInfoModalitie4.Image => "image",
                ResponseItemVariant1DatasetsServerInfoModalitie4.Tabular => "tabular",
                ResponseItemVariant1DatasetsServerInfoModalitie4.Text => "text",
                ResponseItemVariant1DatasetsServerInfoModalitie4.Timeseries => "timeseries",
                ResponseItemVariant1DatasetsServerInfoModalitie4.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoModalitie4? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseItemVariant1DatasetsServerInfoModalitie4.x3d,
                "audio" => ResponseItemVariant1DatasetsServerInfoModalitie4.Audio,
                "document" => ResponseItemVariant1DatasetsServerInfoModalitie4.Document,
                "geospatial" => ResponseItemVariant1DatasetsServerInfoModalitie4.Geospatial,
                "image" => ResponseItemVariant1DatasetsServerInfoModalitie4.Image,
                "tabular" => ResponseItemVariant1DatasetsServerInfoModalitie4.Tabular,
                "text" => ResponseItemVariant1DatasetsServerInfoModalitie4.Text,
                "timeseries" => ResponseItemVariant1DatasetsServerInfoModalitie4.Timeseries,
                "video" => ResponseItemVariant1DatasetsServerInfoModalitie4.Video,
                _ => null,
            };
        }
    }
}