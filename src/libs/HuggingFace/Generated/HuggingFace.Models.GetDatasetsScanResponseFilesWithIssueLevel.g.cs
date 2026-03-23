
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsScanResponseFilesWithIssueLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Caution,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Safe,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
        /// <summary>
        /// 
        /// </summary>
        Unsafe,
        /// <summary>
        /// 
        /// </summary>
        Unscanned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsScanResponseFilesWithIssueLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsScanResponseFilesWithIssueLevel value)
        {
            return value switch
            {
                GetDatasetsScanResponseFilesWithIssueLevel.Caution => "caution",
                GetDatasetsScanResponseFilesWithIssueLevel.Error => "error",
                GetDatasetsScanResponseFilesWithIssueLevel.Queued => "queued",
                GetDatasetsScanResponseFilesWithIssueLevel.Safe => "safe",
                GetDatasetsScanResponseFilesWithIssueLevel.Suspicious => "suspicious",
                GetDatasetsScanResponseFilesWithIssueLevel.Unsafe => "unsafe",
                GetDatasetsScanResponseFilesWithIssueLevel.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsScanResponseFilesWithIssueLevel? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetDatasetsScanResponseFilesWithIssueLevel.Caution,
                "error" => GetDatasetsScanResponseFilesWithIssueLevel.Error,
                "queued" => GetDatasetsScanResponseFilesWithIssueLevel.Queued,
                "safe" => GetDatasetsScanResponseFilesWithIssueLevel.Safe,
                "suspicious" => GetDatasetsScanResponseFilesWithIssueLevel.Suspicious,
                "unsafe" => GetDatasetsScanResponseFilesWithIssueLevel.Unsafe,
                "unscanned" => GetDatasetsScanResponseFilesWithIssueLevel.Unscanned,
                _ => null,
            };
        }
    }
}