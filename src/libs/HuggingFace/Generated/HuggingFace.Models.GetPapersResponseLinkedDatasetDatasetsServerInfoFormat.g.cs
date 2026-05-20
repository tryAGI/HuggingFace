
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedDatasetDatasetsServerInfoFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AgentTraces,
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
    public static class GetPapersResponseLinkedDatasetDatasetsServerInfoFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedDatasetDatasetsServerInfoFormat value)
        {
            return value switch
            {
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.AgentTraces => "agent-traces",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Arrow => "arrow",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Audiofolder => "audiofolder",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Csv => "csv",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Imagefolder => "imagefolder",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Json => "json",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.OptimizedParquet => "optimized-parquet",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Parquet => "parquet",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Text => "text",
                GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedDatasetDatasetsServerInfoFormat? ToEnum(string value)
        {
            return value switch
            {
                "agent-traces" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.AgentTraces,
                "arrow" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Arrow,
                "audiofolder" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Audiofolder,
                "csv" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Csv,
                "imagefolder" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Imagefolder,
                "json" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Json,
                "optimized-parquet" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.OptimizedParquet,
                "parquet" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Parquet,
                "text" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Text,
                "webdataset" => GetPapersResponseLinkedDatasetDatasetsServerInfoFormat.Webdataset,
                _ => null,
            };
        }
    }
}