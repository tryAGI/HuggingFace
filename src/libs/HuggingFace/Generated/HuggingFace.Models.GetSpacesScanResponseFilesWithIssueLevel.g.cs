
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesScanResponseFilesWithIssueLevel
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
    public static class GetSpacesScanResponseFilesWithIssueLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesScanResponseFilesWithIssueLevel value)
        {
            return value switch
            {
                GetSpacesScanResponseFilesWithIssueLevel.Caution => "caution",
                GetSpacesScanResponseFilesWithIssueLevel.Error => "error",
                GetSpacesScanResponseFilesWithIssueLevel.Queued => "queued",
                GetSpacesScanResponseFilesWithIssueLevel.Safe => "safe",
                GetSpacesScanResponseFilesWithIssueLevel.Suspicious => "suspicious",
                GetSpacesScanResponseFilesWithIssueLevel.Unsafe => "unsafe",
                GetSpacesScanResponseFilesWithIssueLevel.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesScanResponseFilesWithIssueLevel? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetSpacesScanResponseFilesWithIssueLevel.Caution,
                "error" => GetSpacesScanResponseFilesWithIssueLevel.Error,
                "queued" => GetSpacesScanResponseFilesWithIssueLevel.Queued,
                "safe" => GetSpacesScanResponseFilesWithIssueLevel.Safe,
                "suspicious" => GetSpacesScanResponseFilesWithIssueLevel.Suspicious,
                "unsafe" => GetSpacesScanResponseFilesWithIssueLevel.Unsafe,
                "unscanned" => GetSpacesScanResponseFilesWithIssueLevel.Unscanned,
                _ => null,
            };
        }
    }
}