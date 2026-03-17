
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoModalitie
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
    public static class ResponseItemVariant1DatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoModalitie value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoModalitie.x3d => "3d",
                ResponseItemVariant1DatasetsServerInfoModalitie.Audio => "audio",
                ResponseItemVariant1DatasetsServerInfoModalitie.Document => "document",
                ResponseItemVariant1DatasetsServerInfoModalitie.Geospatial => "geospatial",
                ResponseItemVariant1DatasetsServerInfoModalitie.Image => "image",
                ResponseItemVariant1DatasetsServerInfoModalitie.Tabular => "tabular",
                ResponseItemVariant1DatasetsServerInfoModalitie.Text => "text",
                ResponseItemVariant1DatasetsServerInfoModalitie.Timeseries => "timeseries",
                ResponseItemVariant1DatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseItemVariant1DatasetsServerInfoModalitie.x3d,
                "audio" => ResponseItemVariant1DatasetsServerInfoModalitie.Audio,
                "document" => ResponseItemVariant1DatasetsServerInfoModalitie.Document,
                "geospatial" => ResponseItemVariant1DatasetsServerInfoModalitie.Geospatial,
                "image" => ResponseItemVariant1DatasetsServerInfoModalitie.Image,
                "tabular" => ResponseItemVariant1DatasetsServerInfoModalitie.Tabular,
                "text" => ResponseItemVariant1DatasetsServerInfoModalitie.Text,
                "timeseries" => ResponseItemVariant1DatasetsServerInfoModalitie.Timeseries,
                "video" => ResponseItemVariant1DatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}