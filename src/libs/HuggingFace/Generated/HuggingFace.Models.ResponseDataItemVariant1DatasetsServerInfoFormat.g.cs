
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1DatasetsServerInfoFormat
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
    public static class ResponseDataItemVariant1DatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1DatasetsServerInfoFormat value)
        {
            return value switch
            {
                ResponseDataItemVariant1DatasetsServerInfoFormat.Json => "json",
                ResponseDataItemVariant1DatasetsServerInfoFormat.Csv => "csv",
                ResponseDataItemVariant1DatasetsServerInfoFormat.Parquet => "parquet",
                ResponseDataItemVariant1DatasetsServerInfoFormat.Imagefolder => "imagefolder",
                ResponseDataItemVariant1DatasetsServerInfoFormat.Audiofolder => "audiofolder",
                ResponseDataItemVariant1DatasetsServerInfoFormat.Webdataset => "webdataset",
                ResponseDataItemVariant1DatasetsServerInfoFormat.Text => "text",
                ResponseDataItemVariant1DatasetsServerInfoFormat.Arrow => "arrow",
                ResponseDataItemVariant1DatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1DatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseDataItemVariant1DatasetsServerInfoFormat.Json,
                "csv" => ResponseDataItemVariant1DatasetsServerInfoFormat.Csv,
                "parquet" => ResponseDataItemVariant1DatasetsServerInfoFormat.Parquet,
                "imagefolder" => ResponseDataItemVariant1DatasetsServerInfoFormat.Imagefolder,
                "audiofolder" => ResponseDataItemVariant1DatasetsServerInfoFormat.Audiofolder,
                "webdataset" => ResponseDataItemVariant1DatasetsServerInfoFormat.Webdataset,
                "text" => ResponseDataItemVariant1DatasetsServerInfoFormat.Text,
                "arrow" => ResponseDataItemVariant1DatasetsServerInfoFormat.Arrow,
                "optimized-parquet" => ResponseDataItemVariant1DatasetsServerInfoFormat.OptimizedParquet,
                _ => null,
            };
        }
    }
}