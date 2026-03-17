
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie
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
    public static class ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.x3d => "3d",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Audio => "audio",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Document => "document",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Geospatial => "geospatial",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Image => "image",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Tabular => "tabular",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Text => "text",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Timeseries => "timeseries",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.x3d,
                "audio" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Audio,
                "document" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Document,
                "geospatial" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Geospatial,
                "image" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Image,
                "tabular" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Tabular,
                "text" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Text,
                "timeseries" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Timeseries,
                "video" => ResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}