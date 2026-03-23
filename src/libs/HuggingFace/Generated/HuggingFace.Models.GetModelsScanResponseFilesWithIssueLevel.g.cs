
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsScanResponseFilesWithIssueLevel
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
    public static class GetModelsScanResponseFilesWithIssueLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsScanResponseFilesWithIssueLevel value)
        {
            return value switch
            {
                GetModelsScanResponseFilesWithIssueLevel.Caution => "caution",
                GetModelsScanResponseFilesWithIssueLevel.Error => "error",
                GetModelsScanResponseFilesWithIssueLevel.Queued => "queued",
                GetModelsScanResponseFilesWithIssueLevel.Safe => "safe",
                GetModelsScanResponseFilesWithIssueLevel.Suspicious => "suspicious",
                GetModelsScanResponseFilesWithIssueLevel.Unsafe => "unsafe",
                GetModelsScanResponseFilesWithIssueLevel.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsScanResponseFilesWithIssueLevel? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetModelsScanResponseFilesWithIssueLevel.Caution,
                "error" => GetModelsScanResponseFilesWithIssueLevel.Error,
                "queued" => GetModelsScanResponseFilesWithIssueLevel.Queued,
                "safe" => GetModelsScanResponseFilesWithIssueLevel.Safe,
                "suspicious" => GetModelsScanResponseFilesWithIssueLevel.Suspicious,
                "unsafe" => GetModelsScanResponseFilesWithIssueLevel.Unsafe,
                "unscanned" => GetModelsScanResponseFilesWithIssueLevel.Unscanned,
                _ => null,
            };
        }
    }
}