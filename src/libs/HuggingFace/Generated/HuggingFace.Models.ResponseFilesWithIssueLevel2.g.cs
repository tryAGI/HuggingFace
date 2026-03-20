
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFilesWithIssueLevel2
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
    public static class ResponseFilesWithIssueLevel2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFilesWithIssueLevel2 value)
        {
            return value switch
            {
                ResponseFilesWithIssueLevel2.Unscanned => "unscanned",
                ResponseFilesWithIssueLevel2.Safe => "safe",
                ResponseFilesWithIssueLevel2.Queued => "queued",
                ResponseFilesWithIssueLevel2.Error => "error",
                ResponseFilesWithIssueLevel2.Caution => "caution",
                ResponseFilesWithIssueLevel2.Suspicious => "suspicious",
                ResponseFilesWithIssueLevel2.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFilesWithIssueLevel2? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseFilesWithIssueLevel2.Unscanned,
                "safe" => ResponseFilesWithIssueLevel2.Safe,
                "queued" => ResponseFilesWithIssueLevel2.Queued,
                "error" => ResponseFilesWithIssueLevel2.Error,
                "caution" => ResponseFilesWithIssueLevel2.Caution,
                "suspicious" => ResponseFilesWithIssueLevel2.Suspicious,
                "unsafe" => ResponseFilesWithIssueLevel2.Unsafe,
                _ => null,
            };
        }
    }
}