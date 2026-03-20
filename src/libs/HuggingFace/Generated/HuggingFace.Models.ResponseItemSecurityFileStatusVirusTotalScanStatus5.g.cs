
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanStatus5
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanStatus5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanStatus5.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusVirusTotalScanStatus5.Safe => "safe",
                ResponseItemSecurityFileStatusVirusTotalScanStatus5.Queued => "queued",
                ResponseItemSecurityFileStatusVirusTotalScanStatus5.Error => "error",
                ResponseItemSecurityFileStatusVirusTotalScanStatus5.Caution => "caution",
                ResponseItemSecurityFileStatusVirusTotalScanStatus5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanStatus5.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanStatus5? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusVirusTotalScanStatus5.Unscanned,
                "safe" => ResponseItemSecurityFileStatusVirusTotalScanStatus5.Safe,
                "queued" => ResponseItemSecurityFileStatusVirusTotalScanStatus5.Queued,
                "error" => ResponseItemSecurityFileStatusVirusTotalScanStatus5.Error,
                "caution" => ResponseItemSecurityFileStatusVirusTotalScanStatus5.Caution,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanStatus5.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusVirusTotalScanStatus5.Unsafe,
                _ => null,
            };
        }
    }
}