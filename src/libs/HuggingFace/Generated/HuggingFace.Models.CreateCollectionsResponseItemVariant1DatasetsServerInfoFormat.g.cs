
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat
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
    public static class CreateCollectionsResponseItemVariant1DatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Arrow => "arrow",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Audiofolder => "audiofolder",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Csv => "csv",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Imagefolder => "imagefolder",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Json => "json",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Parquet => "parquet",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Text => "text",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "arrow" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Arrow,
                "audiofolder" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Audiofolder,
                "csv" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Csv,
                "imagefolder" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Imagefolder,
                "json" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Json,
                "optimized-parquet" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.OptimizedParquet,
                "parquet" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Parquet,
                "text" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Text,
                "webdataset" => CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat.Webdataset,
                _ => null,
            };
        }
    }
}