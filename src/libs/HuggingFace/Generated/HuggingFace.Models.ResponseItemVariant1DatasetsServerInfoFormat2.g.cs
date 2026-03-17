
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoFormat2
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
    public static class ResponseItemVariant1DatasetsServerInfoFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoFormat2 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoFormat2.Json => "json",
                ResponseItemVariant1DatasetsServerInfoFormat2.Csv => "csv",
                ResponseItemVariant1DatasetsServerInfoFormat2.Parquet => "parquet",
                ResponseItemVariant1DatasetsServerInfoFormat2.Imagefolder => "imagefolder",
                ResponseItemVariant1DatasetsServerInfoFormat2.Audiofolder => "audiofolder",
                ResponseItemVariant1DatasetsServerInfoFormat2.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoFormat2.Text => "text",
                ResponseItemVariant1DatasetsServerInfoFormat2.Arrow => "arrow",
                ResponseItemVariant1DatasetsServerInfoFormat2.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseItemVariant1DatasetsServerInfoFormat2.Json,
                "csv" => ResponseItemVariant1DatasetsServerInfoFormat2.Csv,
                "parquet" => ResponseItemVariant1DatasetsServerInfoFormat2.Parquet,
                "imagefolder" => ResponseItemVariant1DatasetsServerInfoFormat2.Imagefolder,
                "audiofolder" => ResponseItemVariant1DatasetsServerInfoFormat2.Audiofolder,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoFormat2.Webdataset,
                "text" => ResponseItemVariant1DatasetsServerInfoFormat2.Text,
                "arrow" => ResponseItemVariant1DatasetsServerInfoFormat2.Arrow,
                "optimized-parquet" => ResponseItemVariant1DatasetsServerInfoFormat2.OptimizedParquet,
                _ => null,
            };
        }
    }
}