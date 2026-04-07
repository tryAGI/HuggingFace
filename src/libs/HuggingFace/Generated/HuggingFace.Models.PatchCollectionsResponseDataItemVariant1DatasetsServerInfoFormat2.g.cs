
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2
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
    public static class PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.AgentTraces => "agent-traces",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Arrow => "arrow",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Audiofolder => "audiofolder",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Csv => "csv",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Imagefolder => "imagefolder",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Json => "json",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.OptimizedParquet => "optimized-parquet",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Parquet => "parquet",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Text => "text",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2? ToEnum(string value)
        {
            return value switch
            {
                "agent-traces" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.AgentTraces,
                "arrow" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Arrow,
                "audiofolder" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Audiofolder,
                "csv" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Csv,
                "imagefolder" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Imagefolder,
                "json" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Json,
                "optimized-parquet" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.OptimizedParquet,
                "parquet" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Parquet,
                "text" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Text,
                "webdataset" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2.Webdataset,
                _ => null,
            };
        }
    }
}