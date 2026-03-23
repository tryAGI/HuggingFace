
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat
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
    public static class CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Arrow => "arrow",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Audiofolder => "audiofolder",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Csv => "csv",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Imagefolder => "imagefolder",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Json => "json",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Parquet => "parquet",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Text => "text",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "arrow" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Arrow,
                "audiofolder" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Audiofolder,
                "csv" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Csv,
                "imagefolder" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Imagefolder,
                "json" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Json,
                "optimized-parquet" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.OptimizedParquet,
                "parquet" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Parquet,
                "text" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Text,
                "webdataset" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat.Webdataset,
                _ => null,
            };
        }
    }
}