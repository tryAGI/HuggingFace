
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanStatus2
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanStatus2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanStatus2.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusVirusTotalScanStatus2.Safe => "safe",
                ResponseItemSecurityFileStatusVirusTotalScanStatus2.Queued => "queued",
                ResponseItemSecurityFileStatusVirusTotalScanStatus2.Error => "error",
                ResponseItemSecurityFileStatusVirusTotalScanStatus2.Caution => "caution",
                ResponseItemSecurityFileStatusVirusTotalScanStatus2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanStatus2.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanStatus2? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusVirusTotalScanStatus2.Unscanned,
                "safe" => ResponseItemSecurityFileStatusVirusTotalScanStatus2.Safe,
                "queued" => ResponseItemSecurityFileStatusVirusTotalScanStatus2.Queued,
                "error" => ResponseItemSecurityFileStatusVirusTotalScanStatus2.Error,
                "caution" => ResponseItemSecurityFileStatusVirusTotalScanStatus2.Caution,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanStatus2.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusVirusTotalScanStatus2.Unsafe,
                _ => null,
            };
        }
    }
}