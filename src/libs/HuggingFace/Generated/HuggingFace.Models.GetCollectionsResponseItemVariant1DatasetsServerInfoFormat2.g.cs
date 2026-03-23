
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2
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
    public static class GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Arrow => "arrow",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Audiofolder => "audiofolder",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Csv => "csv",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Imagefolder => "imagefolder",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Json => "json",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.OptimizedParquet => "optimized-parquet",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Parquet => "parquet",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Text => "text",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2? ToEnum(string value)
        {
            return value switch
            {
                "arrow" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Arrow,
                "audiofolder" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Audiofolder,
                "csv" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Csv,
                "imagefolder" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Imagefolder,
                "json" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Json,
                "optimized-parquet" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.OptimizedParquet,
                "parquet" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Parquet,
                "text" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Text,
                "webdataset" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2.Webdataset,
                _ => null,
            };
        }
    }
}