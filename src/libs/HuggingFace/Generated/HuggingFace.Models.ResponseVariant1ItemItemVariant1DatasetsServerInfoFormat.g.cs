
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat
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
    public static class ResponseVariant1ItemItemVariant1DatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Json => "json",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Csv => "csv",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Parquet => "parquet",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Imagefolder => "imagefolder",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Audiofolder => "audiofolder",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Webdataset => "webdataset",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Text => "text",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Arrow => "arrow",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Json,
                "csv" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Csv,
                "parquet" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Parquet,
                "imagefolder" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Imagefolder,
                "audiofolder" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Audiofolder,
                "webdataset" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Webdataset,
                "text" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Text,
                "arrow" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.Arrow,
                "optimized-parquet" => ResponseVariant1ItemItemVariant1DatasetsServerInfoFormat.OptimizedParquet,
                _ => null,
            };
        }
    }
}