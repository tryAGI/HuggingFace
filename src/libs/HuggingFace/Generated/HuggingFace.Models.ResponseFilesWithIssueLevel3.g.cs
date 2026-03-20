
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFilesWithIssueLevel3
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
    public static class ResponseFilesWithIssueLevel3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFilesWithIssueLevel3 value)
        {
            return value switch
            {
                ResponseFilesWithIssueLevel3.Unscanned => "unscanned",
                ResponseFilesWithIssueLevel3.Safe => "safe",
                ResponseFilesWithIssueLevel3.Queued => "queued",
                ResponseFilesWithIssueLevel3.Error => "error",
                ResponseFilesWithIssueLevel3.Caution => "caution",
                ResponseFilesWithIssueLevel3.Suspicious => "suspicious",
                ResponseFilesWithIssueLevel3.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFilesWithIssueLevel3? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseFilesWithIssueLevel3.Unscanned,
                "safe" => ResponseFilesWithIssueLevel3.Safe,
                "queued" => ResponseFilesWithIssueLevel3.Queued,
                "error" => ResponseFilesWithIssueLevel3.Error,
                "caution" => ResponseFilesWithIssueLevel3.Caution,
                "suspicious" => ResponseFilesWithIssueLevel3.Suspicious,
                "unsafe" => ResponseFilesWithIssueLevel3.Unsafe,
                _ => null,
            };
        }
    }
}