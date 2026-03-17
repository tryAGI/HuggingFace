
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Parquet,
        /// <summary>
        /// 
        /// </summary>
        Imagefolder,
        /// <summary>
        /// 
        /// </summary>
        Audiofolder,
        /// <summary>
        /// 
        /// </summary>
        Webdataset,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Arrow,
        /// <summary>
        /// 
        /// </summary>
        OptimizedParquet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Json => "json",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Csv => "csv",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Parquet => "parquet",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Imagefolder => "imagefolder",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Audiofolder => "audiofolder",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Webdataset => "webdataset",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Text => "text",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Arrow => "arrow",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Json,
                "csv" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Csv,
                "parquet" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Parquet,
                "imagefolder" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Imagefolder,
                "audiofolder" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Audiofolder,
                "webdataset" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Webdataset,
                "text" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Text,
                "arrow" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.Arrow,
                "optimized-parquet" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat.OptimizedParquet,
                _ => null,
            };
        }
    }
}