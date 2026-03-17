
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoFormat4
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
    public static class ResponseItemVariant1DatasetsServerInfoFormat4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoFormat4 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoFormat4.Json => "json",
                ResponseItemVariant1DatasetsServerInfoFormat4.Csv => "csv",
                ResponseItemVariant1DatasetsServerInfoFormat4.Parquet => "parquet",
                ResponseItemVariant1DatasetsServerInfoFormat4.Imagefolder => "imagefolder",
                ResponseItemVariant1DatasetsServerInfoFormat4.Audiofolder => "audiofolder",
                ResponseItemVariant1DatasetsServerInfoFormat4.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoFormat4.Text => "text",
                ResponseItemVariant1DatasetsServerInfoFormat4.Arrow => "arrow",
                ResponseItemVariant1DatasetsServerInfoFormat4.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoFormat4? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseItemVariant1DatasetsServerInfoFormat4.Json,
                "csv" => ResponseItemVariant1DatasetsServerInfoFormat4.Csv,
                "parquet" => ResponseItemVariant1DatasetsServerInfoFormat4.Parquet,
                "imagefolder" => ResponseItemVariant1DatasetsServerInfoFormat4.Imagefolder,
                "audiofolder" => ResponseItemVariant1DatasetsServerInfoFormat4.Audiofolder,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoFormat4.Webdataset,
                "text" => ResponseItemVariant1DatasetsServerInfoFormat4.Text,
                "arrow" => ResponseItemVariant1DatasetsServerInfoFormat4.Arrow,
                "optimized-parquet" => ResponseItemVariant1DatasetsServerInfoFormat4.OptimizedParquet,
                _ => null,
            };
        }
    }
}