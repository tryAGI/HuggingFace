
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanStatus4
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanStatus4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanStatus4.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusVirusTotalScanStatus4.Safe => "safe",
                ResponseItemSecurityFileStatusVirusTotalScanStatus4.Queued => "queued",
                ResponseItemSecurityFileStatusVirusTotalScanStatus4.Error => "error",
                ResponseItemSecurityFileStatusVirusTotalScanStatus4.Caution => "caution",
                ResponseItemSecurityFileStatusVirusTotalScanStatus4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanStatus4.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanStatus4? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusVirusTotalScanStatus4.Unscanned,
                "safe" => ResponseItemSecurityFileStatusVirusTotalScanStatus4.Safe,
                "queued" => ResponseItemSecurityFileStatusVirusTotalScanStatus4.Queued,
                "error" => ResponseItemSecurityFileStatusVirusTotalScanStatus4.Error,
                "caution" => ResponseItemSecurityFileStatusVirusTotalScanStatus4.Caution,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanStatus4.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusVirusTotalScanStatus4.Unsafe,
                _ => null,
            };
        }
    }
}