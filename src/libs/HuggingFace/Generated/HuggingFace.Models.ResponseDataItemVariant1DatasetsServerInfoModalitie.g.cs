
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1DatasetsServerInfoModalitie
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
    public static class ResponseDataItemVariant1DatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1DatasetsServerInfoModalitie value)
        {
            return value switch
            {
                ResponseDataItemVariant1DatasetsServerInfoModalitie.x3d => "3d",
                ResponseDataItemVariant1DatasetsServerInfoModalitie.Audio => "audio",
                ResponseDataItemVariant1DatasetsServerInfoModalitie.Document => "document",
                ResponseDataItemVariant1DatasetsServerInfoModalitie.Geospatial => "geospatial",
                ResponseDataItemVariant1DatasetsServerInfoModalitie.Image => "image",
                ResponseDataItemVariant1DatasetsServerInfoModalitie.Tabular => "tabular",
                ResponseDataItemVariant1DatasetsServerInfoModalitie.Text => "text",
                ResponseDataItemVariant1DatasetsServerInfoModalitie.Timeseries => "timeseries",
                ResponseDataItemVariant1DatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1DatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseDataItemVariant1DatasetsServerInfoModalitie.x3d,
                "audio" => ResponseDataItemVariant1DatasetsServerInfoModalitie.Audio,
                "document" => ResponseDataItemVariant1DatasetsServerInfoModalitie.Document,
                "geospatial" => ResponseDataItemVariant1DatasetsServerInfoModalitie.Geospatial,
                "image" => ResponseDataItemVariant1DatasetsServerInfoModalitie.Image,
                "tabular" => ResponseDataItemVariant1DatasetsServerInfoModalitie.Tabular,
                "text" => ResponseDataItemVariant1DatasetsServerInfoModalitie.Text,
                "timeseries" => ResponseDataItemVariant1DatasetsServerInfoModalitie.Timeseries,
                "video" => ResponseDataItemVariant1DatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}