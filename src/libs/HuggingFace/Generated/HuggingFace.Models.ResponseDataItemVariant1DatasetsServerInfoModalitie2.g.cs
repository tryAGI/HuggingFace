
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1DatasetsServerInfoModalitie2
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
    public static class ResponseDataItemVariant1DatasetsServerInfoModalitie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1DatasetsServerInfoModalitie2 value)
        {
            return value switch
            {
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.x3d => "3d",
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.Audio => "audio",
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.Document => "document",
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.Geospatial => "geospatial",
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.Image => "image",
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.Tabular => "tabular",
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.Text => "text",
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.Timeseries => "timeseries",
                ResponseDataItemVariant1DatasetsServerInfoModalitie2.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1DatasetsServerInfoModalitie2? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.x3d,
                "audio" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.Audio,
                "document" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.Document,
                "geospatial" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.Geospatial,
                "image" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.Image,
                "tabular" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.Tabular,
                "text" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.Text,
                "timeseries" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.Timeseries,
                "video" => ResponseDataItemVariant1DatasetsServerInfoModalitie2.Video,
                _ => null,
            };
        }
    }
}