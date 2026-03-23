
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.x3d => "3d",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Audio => "audio",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Document => "document",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Geospatial => "geospatial",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Image => "image",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Tabular => "tabular",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Text => "text",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Timeseries => "timeseries",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.x3d,
                "audio" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Audio,
                "document" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Document,
                "geospatial" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Geospatial,
                "image" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Image,
                "tabular" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Tabular,
                "text" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Text,
                "timeseries" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Timeseries,
                "video" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}