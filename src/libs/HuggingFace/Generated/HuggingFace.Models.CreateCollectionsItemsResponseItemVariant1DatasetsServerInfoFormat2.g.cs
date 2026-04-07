
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2
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
    public static class CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.AgentTraces => "agent-traces",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Arrow => "arrow",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Audiofolder => "audiofolder",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Csv => "csv",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Imagefolder => "imagefolder",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Json => "json",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.OptimizedParquet => "optimized-parquet",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Parquet => "parquet",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Text => "text",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2? ToEnum(string value)
        {
            return value switch
            {
                "agent-traces" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.AgentTraces,
                "arrow" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Arrow,
                "audiofolder" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Audiofolder,
                "csv" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Csv,
                "imagefolder" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Imagefolder,
                "json" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Json,
                "optimized-parquet" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.OptimizedParquet,
                "parquet" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Parquet,
                "text" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Text,
                "webdataset" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2.Webdataset,
                _ => null,
            };
        }
    }
}