
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoFormat
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
    public static class ResponseItemVariant1DatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoFormat value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoFormat.Json => "json",
                ResponseItemVariant1DatasetsServerInfoFormat.Csv => "csv",
                ResponseItemVariant1DatasetsServerInfoFormat.Parquet => "parquet",
                ResponseItemVariant1DatasetsServerInfoFormat.Imagefolder => "imagefolder",
                ResponseItemVariant1DatasetsServerInfoFormat.Audiofolder => "audiofolder",
                ResponseItemVariant1DatasetsServerInfoFormat.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoFormat.Text => "text",
                ResponseItemVariant1DatasetsServerInfoFormat.Arrow => "arrow",
                ResponseItemVariant1DatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseItemVariant1DatasetsServerInfoFormat.Json,
                "csv" => ResponseItemVariant1DatasetsServerInfoFormat.Csv,
                "parquet" => ResponseItemVariant1DatasetsServerInfoFormat.Parquet,
                "imagefolder" => ResponseItemVariant1DatasetsServerInfoFormat.Imagefolder,
                "audiofolder" => ResponseItemVariant1DatasetsServerInfoFormat.Audiofolder,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoFormat.Webdataset,
                "text" => ResponseItemVariant1DatasetsServerInfoFormat.Text,
                "arrow" => ResponseItemVariant1DatasetsServerInfoFormat.Arrow,
                "optimized-parquet" => ResponseItemVariant1DatasetsServerInfoFormat.OptimizedParquet,
                _ => null,
            };
        }
    }
}