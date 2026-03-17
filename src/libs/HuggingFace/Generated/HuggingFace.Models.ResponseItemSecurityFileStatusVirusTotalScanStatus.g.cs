
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanStatus
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanStatus value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusVirusTotalScanStatus.Safe => "safe",
                ResponseItemSecurityFileStatusVirusTotalScanStatus.Queued => "queued",
                ResponseItemSecurityFileStatusVirusTotalScanStatus.Error => "error",
                ResponseItemSecurityFileStatusVirusTotalScanStatus.Caution => "caution",
                ResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned,
                "safe" => ResponseItemSecurityFileStatusVirusTotalScanStatus.Safe,
                "queued" => ResponseItemSecurityFileStatusVirusTotalScanStatus.Queued,
                "error" => ResponseItemSecurityFileStatusVirusTotalScanStatus.Error,
                "caution" => ResponseItemSecurityFileStatusVirusTotalScanStatus.Caution,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe,
                _ => null,
            };
        }
    }
}