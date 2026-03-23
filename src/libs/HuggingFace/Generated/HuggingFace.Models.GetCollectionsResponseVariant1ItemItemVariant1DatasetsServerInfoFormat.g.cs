
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat
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
    public static class GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Arrow => "arrow",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Audiofolder => "audiofolder",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Csv => "csv",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Imagefolder => "imagefolder",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Json => "json",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Parquet => "parquet",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Text => "text",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "arrow" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Arrow,
                "audiofolder" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Audiofolder,
                "csv" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Csv,
                "imagefolder" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Imagefolder,
                "json" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Json,
                "optimized-parquet" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.OptimizedParquet,
                "parquet" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Parquet,
                "text" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Text,
                "webdataset" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Webdataset,
                _ => null,
            };
        }
    }
}