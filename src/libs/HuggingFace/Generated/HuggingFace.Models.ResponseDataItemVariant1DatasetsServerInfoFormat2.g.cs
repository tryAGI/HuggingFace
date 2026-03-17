
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1DatasetsServerInfoFormat2
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
    public static class ResponseDataItemVariant1DatasetsServerInfoFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1DatasetsServerInfoFormat2 value)
        {
            return value switch
            {
                ResponseDataItemVariant1DatasetsServerInfoFormat2.Json => "json",
                ResponseDataItemVariant1DatasetsServerInfoFormat2.Csv => "csv",
                ResponseDataItemVariant1DatasetsServerInfoFormat2.Parquet => "parquet",
                ResponseDataItemVariant1DatasetsServerInfoFormat2.Imagefolder => "imagefolder",
                ResponseDataItemVariant1DatasetsServerInfoFormat2.Audiofolder => "audiofolder",
                ResponseDataItemVariant1DatasetsServerInfoFormat2.Webdataset => "webdataset",
                ResponseDataItemVariant1DatasetsServerInfoFormat2.Text => "text",
                ResponseDataItemVariant1DatasetsServerInfoFormat2.Arrow => "arrow",
                ResponseDataItemVariant1DatasetsServerInfoFormat2.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1DatasetsServerInfoFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseDataItemVariant1DatasetsServerInfoFormat2.Json,
                "csv" => ResponseDataItemVariant1DatasetsServerInfoFormat2.Csv,
                "parquet" => ResponseDataItemVariant1DatasetsServerInfoFormat2.Parquet,
                "imagefolder" => ResponseDataItemVariant1DatasetsServerInfoFormat2.Imagefolder,
                "audiofolder" => ResponseDataItemVariant1DatasetsServerInfoFormat2.Audiofolder,
                "webdataset" => ResponseDataItemVariant1DatasetsServerInfoFormat2.Webdataset,
                "text" => ResponseDataItemVariant1DatasetsServerInfoFormat2.Text,
                "arrow" => ResponseDataItemVariant1DatasetsServerInfoFormat2.Arrow,
                "optimized-parquet" => ResponseDataItemVariant1DatasetsServerInfoFormat2.OptimizedParquet,
                _ => null,
            };
        }
    }
}