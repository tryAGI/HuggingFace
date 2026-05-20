
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie
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
    public static class GetPapersResponseLinkedDatasetDatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie value)
        {
            return value switch
            {
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.x3d => "3d",
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Audio => "audio",
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Document => "document",
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Geospatial => "geospatial",
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Image => "image",
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Tabular => "tabular",
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Text => "text",
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Timeseries => "timeseries",
                GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.x3d,
                "audio" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Audio,
                "document" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Document,
                "geospatial" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Geospatial,
                "image" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Image,
                "tabular" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Tabular,
                "text" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Text,
                "timeseries" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Timeseries,
                "video" => GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}