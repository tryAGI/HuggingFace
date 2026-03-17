
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie
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
    public static class ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.x3d => "3d",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Audio => "audio",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Document => "document",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Geospatial => "geospatial",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Image => "image",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Tabular => "tabular",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Text => "text",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Timeseries => "timeseries",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.x3d,
                "audio" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Audio,
                "document" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Document,
                "geospatial" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Geospatial,
                "image" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Image,
                "tabular" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Tabular,
                "text" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Text,
                "timeseries" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Timeseries,
                "video" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}