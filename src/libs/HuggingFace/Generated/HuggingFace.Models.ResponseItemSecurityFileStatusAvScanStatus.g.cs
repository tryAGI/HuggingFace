
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanStatus
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
    public static class ResponseItemSecurityFileStatusAvScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanStatus value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanStatus.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusAvScanStatus.Safe => "safe",
                ResponseItemSecurityFileStatusAvScanStatus.Queued => "queued",
                ResponseItemSecurityFileStatusAvScanStatus.Error => "error",
                ResponseItemSecurityFileStatusAvScanStatus.Caution => "caution",
                ResponseItemSecurityFileStatusAvScanStatus.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanStatus.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusAvScanStatus.Unscanned,
                "safe" => ResponseItemSecurityFileStatusAvScanStatus.Safe,
                "queued" => ResponseItemSecurityFileStatusAvScanStatus.Queued,
                "error" => ResponseItemSecurityFileStatusAvScanStatus.Error,
                "caution" => ResponseItemSecurityFileStatusAvScanStatus.Caution,
                "suspicious" => ResponseItemSecurityFileStatusAvScanStatus.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusAvScanStatus.Unsafe,
                _ => null,
            };
        }
    }
}