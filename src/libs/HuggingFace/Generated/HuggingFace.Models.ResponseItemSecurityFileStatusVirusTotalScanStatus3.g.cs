
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanStatus3
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanStatus3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanStatus3.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusVirusTotalScanStatus3.Safe => "safe",
                ResponseItemSecurityFileStatusVirusTotalScanStatus3.Queued => "queued",
                ResponseItemSecurityFileStatusVirusTotalScanStatus3.Error => "error",
                ResponseItemSecurityFileStatusVirusTotalScanStatus3.Caution => "caution",
                ResponseItemSecurityFileStatusVirusTotalScanStatus3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanStatus3.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanStatus3? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusVirusTotalScanStatus3.Unscanned,
                "safe" => ResponseItemSecurityFileStatusVirusTotalScanStatus3.Safe,
                "queued" => ResponseItemSecurityFileStatusVirusTotalScanStatus3.Queued,
                "error" => ResponseItemSecurityFileStatusVirusTotalScanStatus3.Error,
                "caution" => ResponseItemSecurityFileStatusVirusTotalScanStatus3.Caution,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanStatus3.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusVirusTotalScanStatus3.Unsafe,
                _ => null,
            };
        }
    }
}