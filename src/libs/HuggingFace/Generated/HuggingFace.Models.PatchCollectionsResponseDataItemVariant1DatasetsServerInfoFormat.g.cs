
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat
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
    public static class PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.AgentTraces => "agent-traces",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Arrow => "arrow",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Audiofolder => "audiofolder",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Csv => "csv",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Imagefolder => "imagefolder",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Json => "json",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Parquet => "parquet",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Text => "text",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "agent-traces" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.AgentTraces,
                "arrow" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Arrow,
                "audiofolder" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Audiofolder,
                "csv" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Csv,
                "imagefolder" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Imagefolder,
                "json" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Json,
                "optimized-parquet" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.OptimizedParquet,
                "parquet" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Parquet,
                "text" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Text,
                "webdataset" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat.Webdataset,
                _ => null,
            };
        }
    }
}