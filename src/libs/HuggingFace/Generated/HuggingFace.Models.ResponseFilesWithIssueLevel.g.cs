
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFilesWithIssueLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Unscanned,
        /// <summary>
        /// 
        /// </summary>
        Safe,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Caution,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
        /// <summary>
        /// 
        /// </summary>
        Unsafe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFilesWithIssueLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFilesWithIssueLevel value)
        {
            return value switch
            {
                ResponseFilesWithIssueLevel.Unscanned => "unscanned",
                ResponseFilesWithIssueLevel.Safe => "safe",
                ResponseFilesWithIssueLevel.Queued => "queued",
                ResponseFilesWithIssueLevel.Error => "error",
                ResponseFilesWithIssueLevel.Caution => "caution",
                ResponseFilesWithIssueLevel.Suspicious => "suspicious",
                ResponseFilesWithIssueLevel.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFilesWithIssueLevel? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseFilesWithIssueLevel.Unscanned,
                "safe" => ResponseFilesWithIssueLevel.Safe,
                "queued" => ResponseFilesWithIssueLevel.Queued,
                "error" => ResponseFilesWithIssueLevel.Error,
                "caution" => ResponseFilesWithIssueLevel.Caution,
                "suspicious" => ResponseFilesWithIssueLevel.Suspicious,
                "unsafe" => ResponseFilesWithIssueLevel.Unsafe,
                _ => null,
            };
        }
    }
}