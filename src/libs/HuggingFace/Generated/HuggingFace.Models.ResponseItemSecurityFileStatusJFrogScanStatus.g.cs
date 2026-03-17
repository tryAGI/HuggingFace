
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanStatus
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
    public static class ResponseItemSecurityFileStatusJFrogScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanStatus value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanStatus.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusJFrogScanStatus.Safe => "safe",
                ResponseItemSecurityFileStatusJFrogScanStatus.Queued => "queued",
                ResponseItemSecurityFileStatusJFrogScanStatus.Error => "error",
                ResponseItemSecurityFileStatusJFrogScanStatus.Caution => "caution",
                ResponseItemSecurityFileStatusJFrogScanStatus.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanStatus.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusJFrogScanStatus.Unscanned,
                "safe" => ResponseItemSecurityFileStatusJFrogScanStatus.Safe,
                "queued" => ResponseItemSecurityFileStatusJFrogScanStatus.Queued,
                "error" => ResponseItemSecurityFileStatusJFrogScanStatus.Error,
                "caution" => ResponseItemSecurityFileStatusJFrogScanStatus.Caution,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanStatus.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusJFrogScanStatus.Unsafe,
                _ => null,
            };
        }
    }
}