
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Arrow,
        /// <summary>
        /// 
        /// </summary>
        Audiofolder,
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Imagefolder,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        OptimizedParquet,
        /// <summary>
        /// 
        /// </summary>
        Parquet,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Webdataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Arrow => "arrow",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Audiofolder => "audiofolder",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Csv => "csv",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Imagefolder => "imagefolder",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Json => "json",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Parquet => "parquet",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Text => "text",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "arrow" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Arrow,
                "audiofolder" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Audiofolder,
                "csv" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Csv,
                "imagefolder" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Imagefolder,
                "json" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Json,
                "optimized-parquet" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.OptimizedParquet,
                "parquet" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Parquet,
                "text" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Text,
                "webdataset" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Webdataset,
                _ => null,
            };
        }
    }
}