
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoFormat3
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
    public static class ResponseItemVariant1DatasetsServerInfoFormat3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoFormat3 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoFormat3.Json => "json",
                ResponseItemVariant1DatasetsServerInfoFormat3.Csv => "csv",
                ResponseItemVariant1DatasetsServerInfoFormat3.Parquet => "parquet",
                ResponseItemVariant1DatasetsServerInfoFormat3.Imagefolder => "imagefolder",
                ResponseItemVariant1DatasetsServerInfoFormat3.Audiofolder => "audiofolder",
                ResponseItemVariant1DatasetsServerInfoFormat3.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoFormat3.Text => "text",
                ResponseItemVariant1DatasetsServerInfoFormat3.Arrow => "arrow",
                ResponseItemVariant1DatasetsServerInfoFormat3.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoFormat3? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseItemVariant1DatasetsServerInfoFormat3.Json,
                "csv" => ResponseItemVariant1DatasetsServerInfoFormat3.Csv,
                "parquet" => ResponseItemVariant1DatasetsServerInfoFormat3.Parquet,
                "imagefolder" => ResponseItemVariant1DatasetsServerInfoFormat3.Imagefolder,
                "audiofolder" => ResponseItemVariant1DatasetsServerInfoFormat3.Audiofolder,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoFormat3.Webdataset,
                "text" => ResponseItemVariant1DatasetsServerInfoFormat3.Text,
                "arrow" => ResponseItemVariant1DatasetsServerInfoFormat3.Arrow,
                "optimized-parquet" => ResponseItemVariant1DatasetsServerInfoFormat3.OptimizedParquet,
                _ => null,
            };
        }
    }
}