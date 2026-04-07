
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant1DatasetsServerInfoFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AgentTraces,
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
    public static class GetCollectionsResponseItemVariant1DatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1DatasetsServerInfoFormat value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.AgentTraces => "agent-traces",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Arrow => "arrow",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Audiofolder => "audiofolder",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Csv => "csv",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Imagefolder => "imagefolder",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Json => "json",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Parquet => "parquet",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Text => "text",
                GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1DatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "agent-traces" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.AgentTraces,
                "arrow" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Arrow,
                "audiofolder" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Audiofolder,
                "csv" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Csv,
                "imagefolder" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Imagefolder,
                "json" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Json,
                "optimized-parquet" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.OptimizedParquet,
                "parquet" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Parquet,
                "text" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Text,
                "webdataset" => GetCollectionsResponseItemVariant1DatasetsServerInfoFormat.Webdataset,
                _ => null,
            };
        }
    }
}