
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanStatus6
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanStatus6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanStatus6.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusVirusTotalScanStatus6.Safe => "safe",
                ResponseItemSecurityFileStatusVirusTotalScanStatus6.Queued => "queued",
                ResponseItemSecurityFileStatusVirusTotalScanStatus6.Error => "error",
                ResponseItemSecurityFileStatusVirusTotalScanStatus6.Caution => "caution",
                ResponseItemSecurityFileStatusVirusTotalScanStatus6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanStatus6.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanStatus6? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusVirusTotalScanStatus6.Unscanned,
                "safe" => ResponseItemSecurityFileStatusVirusTotalScanStatus6.Safe,
                "queued" => ResponseItemSecurityFileStatusVirusTotalScanStatus6.Queued,
                "error" => ResponseItemSecurityFileStatusVirusTotalScanStatus6.Error,
                "caution" => ResponseItemSecurityFileStatusVirusTotalScanStatus6.Caution,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanStatus6.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusVirusTotalScanStatus6.Unsafe,
                _ => null,
            };
        }
    }
}