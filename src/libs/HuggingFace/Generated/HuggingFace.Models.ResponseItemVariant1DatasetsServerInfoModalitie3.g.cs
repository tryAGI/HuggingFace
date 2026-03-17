
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoModalitie3
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
    public static class ResponseItemVariant1DatasetsServerInfoModalitie3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoModalitie3 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoModalitie3.x3d => "3d",
                ResponseItemVariant1DatasetsServerInfoModalitie3.Audio => "audio",
                ResponseItemVariant1DatasetsServerInfoModalitie3.Document => "document",
                ResponseItemVariant1DatasetsServerInfoModalitie3.Geospatial => "geospatial",
                ResponseItemVariant1DatasetsServerInfoModalitie3.Image => "image",
                ResponseItemVariant1DatasetsServerInfoModalitie3.Tabular => "tabular",
                ResponseItemVariant1DatasetsServerInfoModalitie3.Text => "text",
                ResponseItemVariant1DatasetsServerInfoModalitie3.Timeseries => "timeseries",
                ResponseItemVariant1DatasetsServerInfoModalitie3.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoModalitie3? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseItemVariant1DatasetsServerInfoModalitie3.x3d,
                "audio" => ResponseItemVariant1DatasetsServerInfoModalitie3.Audio,
                "document" => ResponseItemVariant1DatasetsServerInfoModalitie3.Document,
                "geospatial" => ResponseItemVariant1DatasetsServerInfoModalitie3.Geospatial,
                "image" => ResponseItemVariant1DatasetsServerInfoModalitie3.Image,
                "tabular" => ResponseItemVariant1DatasetsServerInfoModalitie3.Tabular,
                "text" => ResponseItemVariant1DatasetsServerInfoModalitie3.Text,
                "timeseries" => ResponseItemVariant1DatasetsServerInfoModalitie3.Timeseries,
                "video" => ResponseItemVariant1DatasetsServerInfoModalitie3.Video,
                _ => null,
            };
        }
    }
}