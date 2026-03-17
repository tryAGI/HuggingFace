
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoFormat5
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
    public static class ResponseItemVariant1DatasetsServerInfoFormat5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoFormat5 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoFormat5.Json => "json",
                ResponseItemVariant1DatasetsServerInfoFormat5.Csv => "csv",
                ResponseItemVariant1DatasetsServerInfoFormat5.Parquet => "parquet",
                ResponseItemVariant1DatasetsServerInfoFormat5.Imagefolder => "imagefolder",
                ResponseItemVariant1DatasetsServerInfoFormat5.Audiofolder => "audiofolder",
                ResponseItemVariant1DatasetsServerInfoFormat5.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoFormat5.Text => "text",
                ResponseItemVariant1DatasetsServerInfoFormat5.Arrow => "arrow",
                ResponseItemVariant1DatasetsServerInfoFormat5.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoFormat5? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseItemVariant1DatasetsServerInfoFormat5.Json,
                "csv" => ResponseItemVariant1DatasetsServerInfoFormat5.Csv,
                "parquet" => ResponseItemVariant1DatasetsServerInfoFormat5.Parquet,
                "imagefolder" => ResponseItemVariant1DatasetsServerInfoFormat5.Imagefolder,
                "audiofolder" => ResponseItemVariant1DatasetsServerInfoFormat5.Audiofolder,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoFormat5.Webdataset,
                "text" => ResponseItemVariant1DatasetsServerInfoFormat5.Text,
                "arrow" => ResponseItemVariant1DatasetsServerInfoFormat5.Arrow,
                "optimized-parquet" => ResponseItemVariant1DatasetsServerInfoFormat5.OptimizedParquet,
                _ => null,
            };
        }
    }
}