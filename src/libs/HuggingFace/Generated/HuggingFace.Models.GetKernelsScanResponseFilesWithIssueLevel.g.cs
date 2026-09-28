
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetKernelsScanResponseFilesWithIssueLevel
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
    public static class GetKernelsScanResponseFilesWithIssueLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsScanResponseFilesWithIssueLevel value)
        {
            return value switch
            {
                GetKernelsScanResponseFilesWithIssueLevel.Caution => "caution",
                GetKernelsScanResponseFilesWithIssueLevel.Error => "error",
                GetKernelsScanResponseFilesWithIssueLevel.Queued => "queued",
                GetKernelsScanResponseFilesWithIssueLevel.Safe => "safe",
                GetKernelsScanResponseFilesWithIssueLevel.Suspicious => "suspicious",
                GetKernelsScanResponseFilesWithIssueLevel.Unsafe => "unsafe",
                GetKernelsScanResponseFilesWithIssueLevel.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsScanResponseFilesWithIssueLevel? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetKernelsScanResponseFilesWithIssueLevel.Caution,
                "error" => GetKernelsScanResponseFilesWithIssueLevel.Error,
                "queued" => GetKernelsScanResponseFilesWithIssueLevel.Queued,
                "safe" => GetKernelsScanResponseFilesWithIssueLevel.Safe,
                "suspicious" => GetKernelsScanResponseFilesWithIssueLevel.Suspicious,
                "unsafe" => GetKernelsScanResponseFilesWithIssueLevel.Unsafe,
                "unscanned" => GetKernelsScanResponseFilesWithIssueLevel.Unscanned,
                _ => null,
            };
        }
    }
}